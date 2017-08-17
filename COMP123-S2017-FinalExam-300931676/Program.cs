using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name: Gursharan Singh
 * Date:17th August, 2017
 * StudentID: 300931676
 * Description: This is GUI for a game involving cards
 * Version: 0.1 Added the splash form
 */

namespace COMP123_S2017_FinalExam_300931676
{
    public static class Program
    {
        public static PickHighestCardForm pickHighestCard;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            pickHighestCard = new PickHighestCardForm();
            Application.Run(new SplashForm());
        }
    }
}
