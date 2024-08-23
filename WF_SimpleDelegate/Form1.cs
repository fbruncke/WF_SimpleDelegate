using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_SimpleDelegate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Calling without using a delegate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            tbOutput.Text = "";
            Looper looper = new Looper(this,0,10);
            looper.Display(null);
        }







        /// <summary>
        /// Calling using a Delegate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            tbOutput.Text = "";
            Looper looper = new Looper(this, 0, 10);
            looper.Display(isOdd);
        }




        /// <summary>
        /// Calling using a Delegate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            tbOutput.Text = "";
            Looper looper = new Looper(this, 0, 10);
            //looper.Display(new ValidateNumber(isEven));
            looper.Display(isEven);
        }

        public bool isEven(int number)
        {
            return number % 2 == 0;
        }

        public bool isOdd(int number)
        {
            return number % 2 != 0;
        }

        public bool IsFactorOfThree(int number)
        {
            return number % 3 == 0;
        }



        #region version without delegate, but with an interface

        /// <summary>
        /// Alternative implementation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            tbOutput.Text = "";
            Looper looper = new Looper(this, 0, 10);
            IValidate ival = new Even();
            looper.Valid = ival;
            looper.Display2();
        }
        #endregion

        private void button5_Click(object sender, EventArgs e)
        {
            tbOutput.Text = "";
            Looper looper = new Looper(this, 0, 10);
            looper.Display(new ValidateNumber(IsFactorOfThree));
        }
    }
}
