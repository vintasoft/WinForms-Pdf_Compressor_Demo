using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

using Vintasoft.Imaging;
using Vintasoft.Imaging.Codecs.ImageFiles.Jpeg2000;
using Vintasoft.Imaging.Pdf;
using Vintasoft.Imaging.Pdf.Processing;
using Vintasoft.Imaging.Pdf.Tree;
using Vintasoft.Imaging.Processing;
using Vintasoft.Imaging.Utils;

using DemosCommonCode;
using DemosCommonCode.Imaging.Codecs.Dialogs;
using DemosCommonCode.Pdf.Security;
using System.Diagnostics;

namespace PdfCompressorDemo
{
    /// <summary>
    /// Main form of PDF Compressor Demo.
    /// </summary>
    public partial class MainForm : Form
    {

        #region Constants

        /// <summary>
        /// Minimum resolution factor.
        /// </summary>
        const double MinResolutionFactor = 1 + 1d / 4d;

        #endregion



        #region Fields

        /// <summary>
        /// Template of the application title.
        /// </summary>
        string _titlePrefix = "VintaSoft PDF Compressor Demo v" + ImagingGlobalSettings.ProductVersion + " {0}";

        /// <summary>
        /// Filename of source PDF document.
        /// </summary>
        string _sourceFilename;

        /// <summary>
        /// Length of PDF document before compression.
        /// </summary>
        long _sourceStreamLength;

        /// <summary>
        /// Current PDF document.
        /// </summary>
        PdfDocument _currentDocument;

        /// <summary>
        /// The command that allows to compress PDF document.
        /// </summary>
        PdfDocumentCompressorCommand _documentCompressorCommand = null;

        /// <summary>
        /// The stream, which must be disposed when PDF document compression is finished.
        /// </summary>
        Stream _streamToDisposeAfterCompress = null;

        /// <summary>
        /// Stream, which contains compressed PDF document.
        /// </summary>
        Stream _compressedStream;

        /// <summary>
        /// Length of PDF document after compression.
        /// </summary>
        long _lengthBeforeCompression;

        /// <summary>
        /// Compression stopwatch;
        /// </summary>
        Stopwatch _compressionStopwatch;


        #region Compression Settings

        /// <summary>
        /// Compression settings for bitonal images.
        /// </summary>
        PdfCompressionSettings _bitonalImagesCompressionSettings = new PdfCompressionSettings();

        /// <summary>
        /// Compression settings for grayscale images.
        /// </summary>
        PdfCompressionSettings _grayImagesCompressionSettings = new PdfCompressionSettings();

        /// <summary>
        /// Compression setting for color images.
        /// </summary>
        PdfCompressionSettings _colorImagesCompressionSettings = new PdfCompressionSettings();

        #endregion

        #endregion



        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            // register the evaluation license for VintaSoft Imaging .NET SDK
            Vintasoft.Imaging.ImagingGlobalSettings.Register("REG_USER", "REG_EMAIL", "EXPIRATION_DATE", "REG_CODE");

            InitializeComponent();

            // load assemblies
            Jbig2AssemblyLoader.Load();
            Jpeg2000AssemblyLoader.Load();

            for (int i = 0; i < taskGroupsTabControl.TabPages.Count; i++)
            {
                taskGroupsCheckedListBox.Items.Add(taskGroupsTabControl.TabPages[i].Text);
                taskGroupsCheckedListBox.SetItemChecked(i, true);
            }

            // init PDF format comboBox
            compressedDocumentFormatComboBox.Items.Add("1.0");
            compressedDocumentFormatComboBox.Items.Add("1.1");
            compressedDocumentFormatComboBox.Items.Add("1.2");
            compressedDocumentFormatComboBox.Items.Add("1.3");
            compressedDocumentFormatComboBox.Items.Add("1.4");
            compressedDocumentFormatComboBox.Items.Add("1.5");
            compressedDocumentFormatComboBox.Items.Add("1.6");
            compressedDocumentFormatComboBox.Items.Add("1.7");
            compressedDocumentFormatComboBox.Items.Add("2.0");

            colorImagesDownscaleNumericUpDown.Value = 150;
            grayImagesDownscaleNumericUpDown.Value = 150;
            blackWhiteImagesDownscaleNumericUpDown.Value = 300;

            compressedDocumentFormatComboBox.SelectedItem = "1.5";

            UpdateUI();
            UpdateCompressionInfo();

            // init image compression settings

            _colorImagesCompressionSettings.JpegSettings.GenerateOptimalHuffmanTables = true;
            _colorImagesCompressionSettings.Jpeg2000Settings.CompressionType = Jpeg2000CompressionType.Lossy;
            _colorImagesCompressionSettings.Jpeg2000Settings.CompressionRatio = 50;

            _grayImagesCompressionSettings.JpegSettings.GenerateOptimalHuffmanTables = true;
            _grayImagesCompressionSettings.Jpeg2000Settings.CompressionType = Jpeg2000CompressionType.Lossy;
            _grayImagesCompressionSettings.Jpeg2000Settings.CompressionRatio = 20;

            _bitonalImagesCompressionSettings.Jbig2Settings.Lossy = true;
            _bitonalImagesCompressionSettings.Jbig2UseGlobals = true;

            // set the initial directory in open file dialog
            DemosTools.SetTestFilesFolder(openFileDialog1);
        }

        #endregion



        #region Methods

        #region UI

        #region Main Form

        /// <summary>
        /// Main form is shown.
        /// </summary>
        private void MainForm_Shown(object sender, EventArgs e)
        {
            // process command line of the application
            string[] appArgs = Environment.GetCommandLineArgs();
            if (appArgs.Length > 0)
            {
                Application.DoEvents();
                if (appArgs.Length == 2)
                {
                    try
                    {
                        OpenDocument(appArgs[1]);
                    }
                    catch
                    {
                        CloseDocument();
                    }
                }
            }
        }

        #endregion


        #region 'File' menu

        /// <summary>
        /// Handles the Click event of OpenToolStripMenuItem object.
        /// </summary>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                OpenDocument(openFileDialog1.FileName);
            }
        }

        /// <summary>
        /// Handles the Click event of SaveToToolStripMenuItem object.
        /// </summary>
        private void saveToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    LogWriteLine("");
                    LogWrite("Save To...");

                    // open output stream
                    using (Stream stream = File.Open(saveFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                    {
                        stream.SetLength(0);

                        int count = 0;
                        byte[] buffer = new byte[8192];
                        _compressedStream.Position = 0;
                        // copy stream that contains compressed PDF document to 
                        // opened file stream
                        while (true)
                        {
                            count = _compressedStream.Read(buffer, 0, buffer.Length);
                            if (count == 0)
                                break;
                            stream.Write(buffer, 0, count);
                        }
                    }

                    LogWriteLine("OK.");
                }
                catch (Exception ex)
                {
                    DemosTools.ShowErrorMessage(ex);
                }
            }
        }

        /// <summary>
        /// Handles the Click event of CloseToolStripMenuItem object.
        /// </summary>
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseDocument();
        }

        /// <summary>
        /// Handles the Click event of ExitToolStripMenuItem object.
        /// </summary>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pdfDocumentCompressionBackgroundWorker.IsBusy)
                pdfDocumentCompressionBackgroundWorker.CancelAsync();

            CloseDocument();
            Close();
        }

        #endregion


        #region 'Tools' menu
      
        /// <summary>
        /// Handles the Click event of InspectSpaceUsageToolStripMenuItem object.
        /// </summary>
        private void inspectSpaceUsageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logTextBox.Clear();
            LogWriteLine("Inspecting document space usage...");

            PdfResource[] resources = _currentDocument.GetResources();
            Dictionary<PdfResourceType, long> resourceTypeToBytes = new Dictionary<PdfResourceType, long>();

            // calculate the size of each resource
            for (int i = 0; i < resources.Length; i++)
            {
                PdfResource resource = resources[i];
                if (resource.ObjectNumber >= 0)
                {
                    if (resourceTypeToBytes.ContainsKey(resource.ResourceType))
                        resourceTypeToBytes[resource.ResourceType] += resource.Length;
                    else
                        resourceTypeToBytes[resource.ResourceType] = resource.Length;
                }
            }

            // calculate number of resources of each type

            long content = 0;
            long images = 0;
            long fonts = 0;
            long embeddedFiles = 0;
            long metadata = 0;
            long iccProfiles = 0;
            long otherStreams = 0;
            long totalStreams = 0;
            foreach (PdfResourceType type in resourceTypeToBytes.Keys)
            {
                long bytes = resourceTypeToBytes[type];
                switch (type)
                {
                    case PdfResourceType.EmbeddedFile:
                        embeddedFiles += bytes;
                        break;

                    case PdfResourceType.FontDescriptorCIDSet:
                    case PdfResourceType.FontProgram:
                    case PdfResourceType.FontToUnicodeMapping:
                        fonts += bytes;
                        break;

                    case PdfResourceType.Form:
                    case PdfResourceType.PageContent:
                        content += bytes;
                        break;

                    case PdfResourceType.ICCProfile:
                        iccProfiles += bytes;
                        break;

                    case PdfResourceType.Image:
                    case PdfResourceType.Jbig2Globals:
                        images += bytes;
                        break;

                    case PdfResourceType.Metadata:
                        metadata += bytes;
                        break;

                    case PdfResourceType.VirtualFontProgram:
                        break;

                    default:
                        otherStreams += bytes;
                        break;
                }
                totalStreams += bytes;
            }

            long total = _currentDocument.StreamLength;

            // calculate the resource sizes in percents

            if (content > 0)
            {
                LogWriteLine(string.Format(CultureInfo.InvariantCulture, "Content           : {1,5:f2}% ({0} bytes)",
                   content, 100 * (1 - (total - content) / (float)total)));
            }
            if (images > 0)
            {
                LogWriteLine(string.Format(CultureInfo.InvariantCulture, "Images            : {1,5:f2}% ({0} bytes)",
                   images, 100 * (1 - (total - images) / (float)total)));
            }
            if (iccProfiles > 0)
            {
                LogWriteLine(string.Format(CultureInfo.InvariantCulture, "ICC Profiles      : {1,5:f2}% ({0} bytes)",
                   iccProfiles, 100 * (1 - (total - iccProfiles) / (float)total)));
            }
            if (fonts > 0)
            {
                LogWriteLine(string.Format(CultureInfo.InvariantCulture, "Fonts             : {1,5:f2}% ({0} bytes)",
                   fonts, 100 * (1 - (total - fonts) / (float)total)));
            }
            if (embeddedFiles > 0)
            {
                LogWriteLine(string.Format(CultureInfo.InvariantCulture, "File attachments  : {1,5:f2}% ({0} bytes)",
                   embeddedFiles, 100 * (1 - (total - embeddedFiles) / (float)total)));
            }
            if (metadata > 0)
            {
                LogWriteLine(string.Format(CultureInfo.InvariantCulture, "Metadata          : {1,5:f2}% ({0} bytes)",
                   metadata, 100 * (1 - (total - metadata) / (float)total)));
            }
            if (otherStreams > 0)
            {
                LogWriteLine(string.Format(CultureInfo.InvariantCulture, "Other stream data : {1,5:f2}% ({0} bytes)",
                       otherStreams, 100 * (1 - (total - otherStreams) / (float)total)));
            }
            LogWriteLine(string.Format(CultureInfo.InvariantCulture, "Other data        : {1,5:f2}% ({0} bytes) (objects, XREF table)",
                total - totalStreams, 100 * (1 - (total - (total - totalStreams)) / (float)total)));

            LogWriteLine("Completed.");
        }

        #endregion


        #region 'Help' menu

        /// <summary>
        /// Handles the Click event of AboutToolStripMenuItem object.
        /// </summary>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AboutBoxForm dialog = new AboutBoxForm())
            {
                dialog.ShowDialog();
            }
        }

        #endregion


        #region 'Main' tab

        /// <summary>
        /// Handles the ItemCheck event of TaskGroupsCheckedListBox object.
        /// </summary>
        private void taskGroupsCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            foreach (TabPage page in taskGroupsTabControl.TabPages)
            {
                if ((string)taskGroupsCheckedListBox.Items[e.Index] == page.Text)
                {
                    // enable/disable selected compression task group
                    foreach (Control c in page.Controls)
                        c.Enabled = e.NewValue == CheckState.Checked;
                }
            }
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of TaskGroupsCheckedListBox object.
        /// </summary>
        private void taskGroupsCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (taskGroupsCheckedListBox.SelectedItem != null)
            {
                foreach (TabPage page in taskGroupsTabControl.TabPages)
                {
                    if ((string)taskGroupsCheckedListBox.SelectedItem == page.Text)
                    {
                        // show selected compression task group
                        taskGroupsTabControl.SelectedTab = page;
                    }
                }
            }
        }

        /// <summary>
        /// Handles the Click event of ExecuteCompressionButton object.
        /// </summary>
        private void executeCompressionButton_Click(object sender, EventArgs e)
        {
            _compressionStopwatch = Stopwatch.StartNew();
            compressionProgressBar.Value = 0;
            logTextBox.Clear();
            if (_compressedStream != null)
                _lengthBeforeCompression = _compressedStream.Length;
            else
                _lengthBeforeCompression = _sourceStreamLength;
            UpdateCompressionInfo();

            _documentCompressorCommand = CreatePdfDocumentCompressor();

            pdfDocumentCompressionBackgroundWorker.RunWorkerAsync();
            UpdateUI();
        }

        #endregion


        #region 'Images' tab

        /// <summary>
        /// Handles the Click event of ColorImagesCompressionSettingsButton object.
        /// </summary>
        private void colorImagesCompressionSettingsButton_Click(object sender, EventArgs e)
        {
            SetCompressionSettings(_colorImagesCompressionSettings, (PdfCompression)colorCompressionComboBox.SelectedItem);
        }

        /// <summary>
        /// Handles the Click event of GrayImagesCompressionSettingsButton object.
        /// </summary>
        private void grayImagesCompressionSettingsButton_Click(object sender, EventArgs e)
        {
            SetCompressionSettings(_grayImagesCompressionSettings, (PdfCompression)grayCompressionComboBox.SelectedItem);
        }

        /// <summary>
        /// Handles the Click event of BlackWhiteImagesCompressionSettingsButton object.
        /// </summary>
        private void blackWhiteImagesCompressionSettingsButton_Click(object sender, EventArgs e)
        {
            SetCompressionSettings(_bitonalImagesCompressionSettings, (PdfCompression)blackWhiteCompressionComboBox.SelectedItem);
        }

        /// <summary>
        /// Handles the ValueChanged event of ColorImagesDownscaleNumericUpDown object.
        /// </summary>
        private void colorImagesDownscaleNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            colorImagesMinResolutionNumericUpDown.Value =
                (int)Math.Round((int)colorImagesDownscaleNumericUpDown.Value * MinResolutionFactor);
        }

        /// <summary>
        /// Handles the ValueChanged event of GrayImagesDownscaleNumericUpDown object.
        /// </summary>
        private void grayImagesDownscaleNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            grayImagesMinResolutionNumericUpDown.Value =
                (int)Math.Round((int)grayImagesDownscaleNumericUpDown.Value * MinResolutionFactor);
        }

        /// <summary>
        /// Handles the ValueChanged event of BitonalImagesDownscaleNumericUpDown object.
        /// </summary>
        private void bitonalImagesDownscaleNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            blackWhiteImagesMinResolutionNumericUpDown.Value =
                (int)Math.Round((int)blackWhiteImagesDownscaleNumericUpDown.Value * MinResolutionFactor);
        }

        #endregion


        #region 'Output Document Format' tab

        /// <summary>
        /// Handles the SelectedIndexChanged event of DocumentFormatComboBox object.
        /// </summary>
        private void documentFormatComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // initialize user interface when document format is changed
            InitUI(new PdfFormat((string)compressedDocumentFormatComboBox.SelectedItem));
        }

        #endregion

        #endregion


        #region UI State

        /// <summary>
        /// Initializes the user interface of this form.
        /// </summary>
        /// <param name="format">PDF document format.</param>
        private void InitUI(PdfFormat format)
        {
            int version = format.VersionNumber;

            // init compression types

            List<object> availableColorCompressions = new List<object>();
            availableColorCompressions.Add(PdfCompression.Lzw);
            availableColorCompressions.Add(PdfCompression.RunLength);
            availableColorCompressions.Add(PdfCompression.Jpeg);

            List<object> availableGrayCompressions = new List<object>();
            availableGrayCompressions.Add(PdfCompression.Lzw);
            availableGrayCompressions.Add(PdfCompression.RunLength);
            availableGrayCompressions.Add(PdfCompression.Jpeg);

            List<object> availableBlackWhiteCompressions = new List<object>();
            availableBlackWhiteCompressions.Add(PdfCompression.CcittFax);

            useFlateInstreadLzwCheckBox.Enabled = version >= 12;
            useFlateInstreadNoneCheckBox.Enabled = version >= 12;
            recompressFlateUsingBestCompressionCheckBox.Enabled = version >= 12;
            if (version >= 12)
            {
                availableColorCompressions.Add(PdfCompression.Zip);
                availableColorCompressions.Add(PdfCompression.Jpeg | PdfCompression.Zip);
                availableGrayCompressions.Add(PdfCompression.Zip);
                availableGrayCompressions.Add(PdfCompression.Jpeg | PdfCompression.Zip);
            }

            if (version >= 14)
            {
                availableBlackWhiteCompressions.Add(PdfCompression.Jbig2);
            }

            if (version >= 15)
            {
                availableColorCompressions.Add(PdfCompression.Jpeg2000);
                availableGrayCompressions.Add(PdfCompression.Jpeg2000);
            }
            useCompressedXrefCheckBox.Enabled = version >= 15;

            // init image compression settings

            colorCompressionComboBox.Items.Clear();
            colorCompressionComboBox.Items.AddRange(availableColorCompressions.ToArray());
            colorCompressionComboBox.SelectedItem = PdfCompression.Jpeg;

            grayCompressionComboBox.Items.Clear();
            grayCompressionComboBox.Items.AddRange(availableGrayCompressions.ToArray());
            grayCompressionComboBox.SelectedItem = PdfCompression.Jpeg;

            blackWhiteCompressionComboBox.Items.Clear();
            blackWhiteCompressionComboBox.Items.AddRange(availableBlackWhiteCompressions.ToArray());

            if (format.VersionNumber >= 14)
                blackWhiteCompressionComboBox.SelectedItem = PdfCompression.Jbig2;
            else
                blackWhiteCompressionComboBox.SelectedItem = PdfCompression.CcittFax;
        }

        /// <summary>
        /// Updates the user interface of this form.
        /// </summary>
        private void UpdateUI()
        {
            bool isOpened = _sourceFilename != null;
            bool isCompressing = pdfDocumentCompressionBackgroundWorker.IsBusy;
            bool isCompressed = _compressedStream != null;
            bool isExecutingCompression = isOpened && _lengthBeforeCompression != 0;

            colorCompressionComboBox.Enabled = compressColorImagesCheckBox.Checked;
            colorImagesCompressionSettingsButton.Enabled = compressColorImagesCheckBox.Checked;
            colorImagesDownscaleNumericUpDown.Enabled = downscaleColorImagesCheckBox.Checked;
            colorImagesMinResolutionNumericUpDown.Enabled = downscaleColorImagesCheckBox.Checked;

            grayCompressionComboBox.Enabled = compressGrayImagesCheckBox.Checked;
            grayImagesCompressionSettingsButton.Enabled = compressGrayImagesCheckBox.Checked;
            grayImagesDownscaleNumericUpDown.Enabled = downscaleGrayImagesCheckBox.Checked;
            grayImagesMinResolutionNumericUpDown.Enabled = downscaleGrayImagesCheckBox.Checked;

            blackWhiteCompressionComboBox.Enabled = compressBlackWhiteImagesCheckBox.Checked;
            blackWhiteImagesCompressionSettingsButton.Enabled = compressBlackWhiteImagesCheckBox.Checked;
            blackWhiteImagesDownscaleNumericUpDown.Enabled = downscaleBlackWhiteImagesCheckBox.Checked;
            blackWhiteImagesMinResolutionNumericUpDown.Enabled = downscaleBlackWhiteImagesCheckBox.Checked;

            taskGroupsCheckedListBox.Enabled = isOpened && !isCompressing;
            executeCompressionButton.Enabled = isOpened && !isExecutingCompression;
            compressedDocumentFormatComboBox.Enabled = isOpened;
            taskGroupsTabControl.Enabled = isOpened && !isCompressing;
            sourceFormatLabel.Visible = isOpened;
            inspectSpaceUsageToolStripMenuItem.Enabled = isOpened && !isExecutingCompression;

            saveToToolStripMenuItem.Enabled = isCompressed && !isExecutingCompression;
            openToolStripMenuItem.Enabled = !isExecutingCompression;
            closeToolStripMenuItem.Enabled = isOpened && !isExecutingCompression;

            if (colorCompressionComboBox.SelectedItem != null)
                colorImagesCompressionSettingsButton.Enabled = CanSetCompressionSettings((PdfCompression)colorCompressionComboBox.SelectedItem);
            if (grayCompressionComboBox.SelectedItem != null)
                grayImagesCompressionSettingsButton.Enabled = CanSetCompressionSettings((PdfCompression)grayCompressionComboBox.SelectedItem);
            if (blackWhiteCompressionComboBox.SelectedItem != null)
                blackWhiteImagesCompressionSettingsButton.Enabled = CanSetCompressionSettings((PdfCompression)blackWhiteCompressionComboBox.SelectedItem);
        }

        /// <summary>
        /// Updates the compression information on this form.
        /// </summary>
        private void UpdateCompressionInfo()
        {
            bool isOpened = _sourceFilename != null;
            bool isCompressed = _compressedStream != null;

            if (isOpened)
            {
                Text = string.Format(_titlePrefix, " - " + Path.GetFileName(_sourceFilename));
                int maxValue;
                int sourceSize;
                int compressedSize;
                if (_compressedStream != null)
                {
                    maxValue = (int)(Math.Max(_sourceStreamLength, _compressedStream.Length) / 1024);
                    sourceSize = (int)(_sourceStreamLength / 1024);
                    compressedSize = (int)(_compressedStream.Length / 1024);
                }
                else
                {
                    maxValue = (int)(_sourceStreamLength / 1024);
                    sourceSize = maxValue;
                    compressedSize = maxValue;
                }
                double compressedPercent = (sourceSize - compressedSize) * 100.0 / maxValue;
                sourceFileSizeLabel.Visible = true;
                sourceFileSizeProgressBar.Maximum = maxValue;
                sourceFileSizeProgressBar.Value = sourceSize;
                sourceFileSizeLabel.Text = string.Format("{0} KB", sourceSize);
                compressedFileSizeLabel.Visible = true;
                compressedFileSizeProgressBar.Maximum = maxValue;
                compressedFileSizeProgressBar.Value = compressedSize;
                compressedFileSizeLabel.Text = string.Format("{0} KB ({1:f2}%)", compressedSize, compressedPercent);
                saveToToolStripMenuItem.Enabled = isCompressed;
            }
            else
            {
                logTextBox.Clear();
                Text = string.Format(_titlePrefix, "");
                compressedFileSizeProgressBar.Value = 0;
                compressedFileSizeLabel.Visible = false;
                sourceFileSizeProgressBar.Value = 0;
                sourceFileSizeLabel.Visible = false;
            }
        }

        /// <summary>
        /// Updates the user interface of this form.
        /// </summary>
        private void UpdateUI_Handler(object sender, EventArgs e)
        {
            UpdateUI();
        }

        #endregion


        #region Background worker

        /// <summary>
        /// The PDF document compression is started.
        /// </summary>
        private void pdfDocumentCompressionBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                using (ProcessingState processingState = new ProcessingState(new ActionProgressController(new ActionProgressHandler(logTextBox, compressionProgressBar))))
                {
                    _documentCompressorCommand.Execute(_currentDocument, processingState);
                }
            }
            catch (Exception ex)
            {
                DemosTools.ShowErrorMessage(ex);
            }
        }

        /// <summary>
        /// The PDF document compression is finished.
        /// </summary>
        private void pdfDocumentCompressionBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
                return;

            // if error occurs
            if (e.Error != null)
            {
                // show the error message
                DemosTools.ShowErrorMessage(e.Error);
            }
            // if PDF document is compressed successfully
            else
            {
                _compressionStopwatch.Stop();
                LogWriteLine("");
                LogWriteLine(string.Format("Time: {0:f3} sec.", _compressionStopwatch.ElapsedMilliseconds / 1000f));
                if (_compressedStream != null)
                {
                    // print the result of PDF document compression

                    LogWriteLine("");
                    double compressionInPercents =
                        (_lengthBeforeCompression - _compressedStream.Length) * 100.0 / _lengthBeforeCompression;
                    LogWriteLine(string.Format("Compression: {0:f2}%.", compressionInPercents));
                }
                compressionProgressBar.Value = 0;
                _lengthBeforeCompression = 0;

                UpdateCompressionInfo();
            }

            if (_streamToDisposeAfterCompress != null)
            {
                _streamToDisposeAfterCompress.Dispose();
                _streamToDisposeAfterCompress = null;
            }

            UpdateUI();
        }

        #endregion


        #region Compression Settings

        /// <summary>
        /// Returns a value indicating whether compresion setting can be used.
        /// </summary>
        /// <param name="compression">PDF compression type.</param>
        private bool CanSetCompressionSettings(PdfCompression compression)
        {
            return
                ((compression & PdfCompression.Jpeg) != 0) ||
                ((compression & PdfCompression.Jpeg2000) != 0) ||
                ((compression & PdfCompression.Jbig2) != 0);
        }

        /// <summary>
        /// Sets an image-resource compression settings.
        /// </summary>
        /// <param name="compressionSettings">PDF compression settings.</param>
        /// <param name="compression">PDF compression type.</param>
        private void SetCompressionSettings(PdfCompressionSettings compressionSettings, PdfCompression compression)
        {
            if ((compression & PdfCompression.Jpeg) != 0)
            {
                using (JpegEncoderSettingsForm dialog = new JpegEncoderSettingsForm())
                {
                    dialog.EncoderSettings = compressionSettings.JpegSettings;
                    dialog.ShowDialog();
                }
            }
            if ((compression & PdfCompression.Jpeg2000) != 0)
            {
                using (Jpeg2000EncoderSettingsForm dialog = new Jpeg2000EncoderSettingsForm())
                {
                    dialog.EncoderSettings = compressionSettings.Jpeg2000Settings;
                    dialog.ShowDialog();
                }
            }
            if ((compression & PdfCompression.Jbig2) != 0)
            {
                using (Jbig2EncoderSettingsForm dialog = new Jbig2EncoderSettingsForm())
                {
                    dialog.EncoderSettings = compressionSettings.Jbig2Settings;
                    dialog.ShowDialog();
                }
            }
        }

        #endregion


        #region Common

        /// <summary>
        /// Opens an existing PDF document.
        /// </summary>
        /// <param name="filename">PDF document filename.</param>
        private void OpenDocument(string filename)
        {
            try
            {
                // close currently opened PDF document
                CloseDocument();

                // open PDF document
                _currentDocument = new PdfDocument(filename, true);
                _sourceFilename = filename;
                _sourceStreamLength = _currentDocument.StreamLength;

                // if authentication is failed
                if (!PdfDocumentPasswordForm.Authenticate(_currentDocument, _sourceFilename))
                {
                    // close PDF document
                    CloseDocument();
                    UpdateUI();
                    UpdateCompressionInfo();
                    return;
                }

                compressedDocumentFormatComboBox.SelectedIndex = 6;
                sourceFormatLabel.Text = string.Format("(source format {0})", _currentDocument.Format.Version);
            }
            catch (Exception ex)
            {
                _sourceFilename = null;
                DemosTools.ShowErrorMessage(ex);
            }
            _compressedStream = null;
            UpdateUI();
            UpdateCompressionInfo();
        }

        /// <summary>
        /// Returns the <see cref="CheckBox"/> state.
        /// </summary>
        /// <param name="panel">The check box panel.</param>
        /// <param name="checkBox">The check box.</param>
        /// <returns>
        /// <b>true</b> if the panel and check are enabled and check box is checked; otherwise, <b>false</b>.
        /// </returns>
        private bool GetCheckState(Panel panel, CheckBox checkBox)
        {
            if (panel.Enabled && checkBox.Enabled)
                return checkBox.Checked;

            return false;
        }

        /// <summary>
        /// Returns the resolution.
        /// </summary>
        /// <param name="numericUpDown">The numeric up down.</param>
        /// <returns>
        /// The resolution.
        /// </returns>
        private Resolution GetResolution(NumericUpDown numericUpDown)
        {
            return new Resolution((int)numericUpDown.Value, (int)numericUpDown.Value);
        }

        /// <summary>
        /// Returns the PDF document compressor command.
        /// </summary>
        /// <returns>
        /// The PDF document compressor.
        /// </returns>
        private PdfDocumentCompressorCommand CreatePdfDocumentCompressor()
        {
            PdfDocumentCompressorCommand command = new PdfDocumentCompressorCommand();

            command.IsMultithreadingEnabled = useMultithreadingToolStripMenuItem.Checked;

            #region  Clean Up / Discard

            command.OptimizeFontSubsets = GetCheckState(cleanUpPanel, optimizeFontSubsetsCheckBox);
            command.SubsetFonts = GetCheckState(cleanUpPanel, subsetFontsCheckBox);
            command.RemoveEmbeddedThumbnails = GetCheckState(cleanUpPanel, removeEmbeddedThumbnailsCheckBox);
            command.RemoveEmbeddedFiles = GetCheckState(cleanUpPanel, removeFileAttachementsCheckBox);
            command.RemoveMetadata = GetCheckState(cleanUpPanel, removeMetadataCheckBox);
            command.RemoveDocumentInformation = GetCheckState(cleanUpPanel, removeDocumentInformationCheckBox);
            command.RemoveBookmarks = GetCheckState(cleanUpPanel, removeBookmarksCheckBox);
            command.RemoveInvalidBookmarks = GetCheckState(cleanUpPanel, removeInvalidBookmarksCheckBox);
            command.RemoveAnnotations = GetCheckState(cleanUpPanel, removeAnnotationsCheckBox);
            command.RemoveInvalidLinks = GetCheckState(cleanUpPanel, removeInvalidLinksCheckBox);
            command.RemoveUnusedPages = GetCheckState(cleanUpPanel, removeUnusedPagesCheckBox);
            command.RemoveUnusedNames = GetCheckState(cleanUpPanel, cleanupNameDictionaryCheckBox);
            command.RemoveUnusedNamedResources = GetCheckState(cleanUpPanel, removeUnusedResourcesCheckBox);
            command.RemoveDuplicateResources = GetCheckState(cleanUpPanel, removeResourceDuplicatesCheckBox);
            command.CleanupContentStreams = GetCheckState(cleanUpPanel, cleanupContentStreamsCheckBox);
            command.RemoveInteractiveForm = GetCheckState(cleanUpPanel, removeInteractiveFormCheckBox);
            command.RemoveStructureTree = GetCheckState(cleanUpPanel, removeStuctureTreeCheckBox);

            #endregion


            #region Images

            // image real color depth detection

            command.DetectBlackWhiteImageResources = GetCheckState(imagesPanel, detectBlackWhiteImagesCheckBox);
            command.DetectGrayscaleImageResources = GetCheckState(imagesPanel, detectGrayscaleImagesCheckBox);
            command.DetectBitonalImageResources = GetCheckState(imagesPanel, detectBitonalImagesCheckBox);
            command.DetectIndexed8ImageResources = GetCheckState(imagesPanel, detectIndexedImagesCheckBox);
            command.ColorDepthDetectionMaxInaccuracy = (float)maxInaccuracyNumericUpDown.Value;


            #region Color images

            if (GetCheckState(imagesPanel, compressColorImagesCheckBox))
                command.ColorImagesCompression = (PdfCompression)colorCompressionComboBox.SelectedItem;
            else
                command.ColorImagesCompression = PdfCompression.Undefined;

            command.ColorImagesCompressionSettings = _colorImagesCompressionSettings;

            if (GetCheckState(imagesPanel, downscaleColorImagesCheckBox))
            {
                command.ColorImagesCompressionResolution = GetResolution(colorImagesDownscaleNumericUpDown);
                command.ColorImagesCompressionMinResolution = GetResolution(colorImagesMinResolutionNumericUpDown);
            }
            else
            {
                command.ColorImagesCompressionResolution = Resolution.Empty;
                command.ColorImagesCompressionMinResolution = Resolution.Empty;
            }

            #endregion


            #region Indexed8 images

            if (GetCheckState(imagesPanel, downscaleColorImagesCheckBox) ||
                GetCheckState(imagesPanel, compressColorImagesCheckBox))
            {
                PdfFormat outputFormat = GetOutputDocumentFormat();

                if (outputFormat.VersionNumber >= 12)
                    command.IndexedImagesCompression = PdfCompression.Zip;
                else
                    command.IndexedImagesCompression = PdfCompression.Lzw;
            }
            else
            {
                command.IndexedImagesCompression = PdfCompression.Undefined;
            }

            #endregion


            #region Grayscale images

            if (GetCheckState(imagesPanel, compressGrayImagesCheckBox))
                command.GrayscaleImagesCompression = (PdfCompression)grayCompressionComboBox.SelectedItem;
            else
                command.GrayscaleImagesCompression = PdfCompression.Undefined;

            command.GrayscaleImagesCompressionSettings = _grayImagesCompressionSettings;

            if (GetCheckState(imagesPanel, downscaleGrayImagesCheckBox))
            {
                command.GrayscaleImagesCompressionResolution = GetResolution(grayImagesDownscaleNumericUpDown);
                command.GrayscaleImagesCompressionMinResolution = GetResolution(grayImagesMinResolutionNumericUpDown);
            }
            else
            {
                command.GrayscaleImagesCompressionResolution = Resolution.Empty;
                command.GrayscaleImagesCompressionMinResolution = Resolution.Empty;
            }

            #endregion


            #region Bitonal images

            if (GetCheckState(imagesPanel, compressBlackWhiteImagesCheckBox))
                command.BitonalImagesCompression = (PdfCompression)blackWhiteCompressionComboBox.SelectedItem;
            else
                command.BitonalImagesCompression = PdfCompression.Undefined;

            command.BitonalImagesCompressionSettings = _bitonalImagesCompressionSettings;

            if (GetCheckState(imagesPanel, downscaleBlackWhiteImagesCheckBox))
            {
                command.BitonalImagesCompressionResolution = GetResolution(blackWhiteImagesDownscaleNumericUpDown);
                command.BitonalImagesCompressionMinResolution = GetResolution(blackWhiteImagesMinResolutionNumericUpDown);
            }
            else
            {
                command.BitonalImagesCompressionResolution = Resolution.Empty;
                command.BitonalImagesCompressionMinResolution = Resolution.Empty;
            }

            #endregion

            #endregion


            #region Resources

            command.FlateCompressionLevel = 9;
            command.RecompressFlateCompression = GetCheckState(resourcesPanel, recompressFlateUsingBestCompressionCheckBox);
            command.UseFlateInsteadLzwCompression = GetCheckState(resourcesPanel, useFlateInstreadLzwCheckBox);
            command.UseFlateInsteadNoneCompression = GetCheckState(resourcesPanel, useFlateInstreadNoneCheckBox);

            #endregion


            #region Pack

            command.PackDocument = true;
            command.DocumentPackFormat = GetOutputDocumentFormat();
            _streamToDisposeAfterCompress = _compressedStream;
            _compressedStream = new MemoryStream();
            command.DocumentPackOutputStream = _compressedStream;

            #endregion

            return command;
        }

        /// <summary>
        /// Returns output PDF document format.
        /// </summary>
        private PdfFormat GetOutputDocumentFormat()
        {
            PdfFormat format = _currentDocument.Format;

            if (documentOutputFormatPanel.Enabled)
            {
                bool binaryFormat = _currentDocument.Format.BinaryFormat;
                bool compressedXref = _currentDocument.Format.CompressedCrossReferenceTable;

                string version = (string)compressedDocumentFormatComboBox.SelectedItem;
                if (useCompressedXrefCheckBox.Enabled)
                    compressedXref = useCompressedXrefCheckBox.Checked;
                else
                    compressedXref = false;
                if (useTextDocumentFormatCheckBox.Enabled)
                    binaryFormat = !useTextDocumentFormatCheckBox.Checked;

                format = new PdfFormat(version, compressedXref, binaryFormat);
            }

            return format;
        }

        /// <summary>
        /// Closes current PDF document.
        /// </summary>
        private void CloseDocument()
        {
            if (_currentDocument != null)
            {
                _currentDocument.Dispose();
                if (_compressedStream != null)
                {
                    _compressedStream.Dispose();
                    _compressedStream = null;
                }
                _sourceFilename = null;
                _sourceStreamLength = 0;
            }
            UpdateUI();
            UpdateCompressionInfo();
        }

        /// <summary>
        /// Appends message to a log.
        /// </summary>
        /// <param name="text">Message text.</param>
        private void LogWriteLine(string text)
        {
            LogWrite(text + Environment.NewLine);
        }

        /// <summary>
        /// Appends message to a log.
        /// </summary>
        /// <param name="text">Message text.</param>
        private void LogWrite(string text)
        {
            logTextBox.AppendText(text);
        }

        #endregion

        #endregion

      
    }
}
