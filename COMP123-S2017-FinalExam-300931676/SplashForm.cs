using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Name: Gursharan Singh
 * Date:17th August, 2017
 * StudentID: 300931676
 * Description: This is GUI for a game involving cards
 * Version: 0.1 Added the tick event handler
 */
namespace COMP123_S2017_FinalExam_300931676
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the tick event handler for the splash form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {

        }
    }
}
