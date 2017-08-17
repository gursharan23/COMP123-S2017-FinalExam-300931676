using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
* Name: Gursharan Singh
* Date:17th August, 2017
* StudentID: 300931676
* Description: This is the scoreboard class
* Version: 0.2 Added the UpdateTime method
*/

namespace COMP123_S2017_FinalExam_300931676
{
    class ScoreBoard
    {
        // Private Instance Variables
        private TextBox _finalScoreTextBox;
        private int _score;
        private TextBox _scoreTextBox;
        private int _time;
        private TextBox _timeTextBox;
        // Public Properties
        public TextBox FinalScoreTextBox
        {
            get
            {
                return this._finalScoreTextBox;
            }
            set
            {
                this._finalScoreTextBox = value;
            }
        }
        public int Score
        {
            get
            {
                return this._score;
            }
            set
            {
                this._score = value;
                this.ScoreTextBox.Text = this._score.ToString();
                this.FinalScoreTextBox.Text = this._score.ToString();
            }
        }
        public TextBox ScoreTextBox
        {
            get
            {
               return this._scoreTextBox;
            }
            set
            {
                this._scoreTextBox = value;
            }
        }
        public int Time
        {
            get
            {
                return this._time;
            }
            set
            {
                this._time = value;
                this.TimeTextBox.Text = this._time.ToString();
            }
        }
        public TextBox TimeTextBox
        {
            get
            {
                return this._timeTextBox;
            }
            set
            {
                this._timeTextBox = value;
            }
        }

        // Constructors
        /// <summary>
        /// This is the main constructor that accepts three arguments - scoreText(TextBox),
        /// timeTextBox(TextBox),finalScoreTextBox(TextBox)
        /// </summary>
        /// <param name="scoreTextBox"></param>
        /// <param name="timeTextBox"></param>
        /// <param name="finalScoreTextBox"></param>
        public ScoreBoard(TextBox scoreTextBox,TextBox timeTextBox,TextBox finalScoreTextBox)
        {
            this.ScoreTextBox= scoreTextBox;
            this.TimeTextBox = timeTextBox;
            this.FinalScoreTextBox = finalScoreTextBox;
        }
        // Private Methods
        // Public Methods
        public void UpdateTime()
        {
            this.Time = Convert.ToInt32(TimeTextBox.Text);
            this.Time -= 1;
            this.TimeTextBox.Text = this.Time.ToString();
        }
    }
}
