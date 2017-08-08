using COMP123_S2017_Lesson12A2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Name: Tom Tsiliopoulos
 * Date: August 8, 2017
 * Description: This is the SplashForm that appears for three seconds
 * and launches the calculator application.
 * Version: 0.2 - Refactored the "Tick" event handler
 */

namespace COMP123_S2017_Lesson12A2
{
    public partial class SplashForm : Form
    {
        //PROPERTIES
        public CalculatorForm CalculatorForm {
            get
            {
                return Program.calculatorForm;
            }

        }

        public SplashForm()
        {
            InitializeComponent();
        }

        /// <summary>
        ///  This is the event handler for the "Tick" event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
            this.CalculatorForm.Show();
            this.Hide();
            SplashFormTimer.Enabled = false;
        }
    }
}
