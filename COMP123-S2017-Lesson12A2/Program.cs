using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Name: Tom Tsiliopoulos
 * Date: August 3, 2017
 * Description: A calculator app with Windows Forms
 * Version: 0.3 - Refactored Main to instantiate CalculatorForm object
 * after Enabling Visual Styles.
 */

namespace COMP123_S2017_Lesson12A2
{
    public static class Program
    {
        // FORM INSTANTIATION
        public static CalculatorForm calculatorForm;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            calculatorForm = new CalculatorForm(); // instantiates object of type Calculator Form

            Application.Run(new SplashForm());
        }
    }
}
