using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Vintasoft.Imaging.Utils;

namespace PdfCompressorDemo
{
    /// <summary>
    /// Shows the progress of action progress controller in the specified progress bar and action description in the specified text box.
    /// </summary>
    public class ActionProgressHandler : IActionProgressHandler
    {

        #region Fields

        /// <summary>
        /// The text box, where action description must be shown.
        /// </summary>
        TextBox _textBox;

        /// <summary>
        /// The progress bar, where action progress must be shown.
        /// </summary>
        ProgressBar _progressBar;

        /// <summary>
        /// Dictionary: action progress level => progress description.
        /// </summary>
        Dictionary<int, string> _levelToMessage = new Dictionary<int, string>();

        #endregion



        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionProgressHandler"/> class.
        /// </summary>
        /// <param name="textBox">The text box, where action description must be shown.</param>
        /// <param name="progressBar">The progress bar, where action progress must be shown.</param>
        public ActionProgressHandler(TextBox textBox, ProgressBar progressBar)
        {
            _textBox = textBox;
            _progressBar = progressBar;
        }

        #endregion



        #region Methods

        #region PUBLIC

        /// <summary>
        /// Called when action step is changed.
        /// </summary>
        /// <param name="actionProgressController">The action progress controller.</param>
        /// <param name="actionStep">The action step.</param>
        /// <param name="canCancel">Indicates that action can be canceled.</param>
        /// <returns>
        /// <b>false</b> action is canceled; otherwise, <b>true</b>.
        /// </returns>
        public bool OnActionStep(ActionProgressController actionProgressController, double actionStep, bool canCancel)
        {
            // action description
            string actionDescription = actionProgressController.ActionDescription;
            // action level
            int actionLevel = actionProgressController.ActionLevel;
            // determines that this is the first step of action
            bool firstStepOfAction = actionStep == 0;

            // if action progress must be shown
            if (actionLevel == 0)
            {
                double actionProgress = 0;
                if (actionProgressController.StepCount > 0)
                {
                    actionProgress = actionStep / actionProgressController.StepCount * 100;

                    // show action progress
                    SetProgressBarValue(actionProgress);
                }
            }

            // if action description is defined
            if (actionDescription != null)
            {
                if (firstStepOfAction)
                {
                    if (actionLevel <= 1)
                        actionDescription = string.Format("{0}.", actionDescription);
                    else
                        actionDescription = string.Format("{0}", actionDescription);
                }
                else
                {
                    actionDescription = "";
                }

                if (actionDescription != "")
                {
                    string prevMessage = null;
                    if (!_levelToMessage.TryGetValue(actionLevel, out prevMessage))
                        prevMessage = null;
                    if (prevMessage != actionDescription)
                    {
                        _levelToMessage[actionLevel] = actionDescription;
                        actionDescription = actionDescription.PadLeft(actionDescription.Length + actionLevel, ' ');

                        AppendLine(actionDescription);
                    }
                }
            }

            return true;
        }

        /// <summary>
        /// Resets this action progress handler.
        /// </summary>
        public void Reset()
        {
        }

        #endregion


        #region PRIVATE

        /// <summary>
        /// Appends the specified line to the text box.
        /// </summary>
        /// <param name="line">The line.</param>
        private void AppendLine(string line)
        {
            if (_textBox.InvokeRequired)
                _textBox.Invoke(new AppendLineDelegate(AppendLine), line);
            else
                _textBox.AppendText(line + Environment.NewLine);
        }

        /// <summary>
        /// Sets the specified progress value to the progress bar value.
        /// </summary>
        /// <param name="value">The progress value.</param>
        private void SetProgressBarValue(double value)
        {
            if (_progressBar.InvokeRequired)
                _progressBar.Invoke(new SetProgressBarValueDelegate(SetProgressBarValue), value);
            else
                _progressBar.Value = (int)Math.Round(value);
        }

        #endregion

        #endregion



        #region Delegates

        /// <summary>
        /// Represents the <see cref="AppendLine"/> delegate.
        /// </summary>
        /// <param name="line">The line.</param>
        private delegate void AppendLineDelegate(string line);

        /// <summary>
        /// Represents the <see cref="SetProgressBarValue"/> delegate.
        /// </summary>
        /// <param name="value">The progress value.</param>
        private delegate void SetProgressBarValueDelegate(double value);

        #endregion

    }
}
