using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Name: Tom Tsiliopoulos
 * Date: August 3, 2017
 * Description: A calculator app with Windows Forms
 * Version: 0.5 - Refactored the CalculatorButton_Click event
 */

namespace COMP123_S2017_Lesson12A2
{
    public partial class CalculatorForm : Form
    {
        // PRIVATE INSTANCE VARIABLES
        private bool _isDecimalClicked;

        // PUBLIC PROPERTIES +++++++++++++++++++++++++++++++
        public bool IsDecimalClicked
        {
            get
            {
                return this._isDecimalClicked;
            }

            set
            {
                this._isDecimalClicked = value;
            }
        }

        // CONSTRUCTORS +++++++++++++++++++++++++++++++++++++++

        /// <summary>
        /// This is the main constructor
        /// </summary>
        public CalculatorForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the event handler for the "FormClosing" event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculatorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // this closes the application
        }

        /// <summary>
        /// This is a shared event handler for the Calculator Buttons
        /// Not including the Operator buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculatorButton_Click(object sender, EventArgs e)
        {
            Button buttonClicked = sender as Button; // downcasting

            if((buttonClicked.Text == ".") && (this.IsDecimalClicked))
            {
                return;
            }

            if (buttonClicked.Text == ".")
            {
                this.IsDecimalClicked = true;
            }

            if(ResultTextBox.Text == "0")
            {
                ResultTextBox.Text = buttonClicked.Text;
            }
            else
            {
                ResultTextBox.Text += buttonClicked.Text;
            }


            //Debug.WriteLine("Calculator Button Clicked");
        }

        /// <summary>
        /// This is the Shared event handler for Operator Buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OperatorButton_Click(object sender, EventArgs e)
        {
            Button operatorButton = sender as Button;

            switch (operatorButton.Text)
            {
                case "C":
                    this._clear();
                    break;
            }
        }

        /// <summary>
        /// This method clears / resets the calculator
        /// </summary>
        private void _clear()
        {
            this.IsDecimalClicked = false;
            this.ResultTextBox.Text = "0";
        }

        /// <summary>
        /// This is the event handler for the Form's "Load" event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculatorForm_Load(object sender, EventArgs e)
        {
            this._clear();
        }
    }
}
