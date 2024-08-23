using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_SimpleDelegate
{

    class Looper
    {
        int start;
        int end;
        Form1 theDisplay;
        //validateNumber validatorDel;        

        //public validateNumber ValidatorDel
        //{
        //    get { return validatorDel; }
        //    set { validatorDel = value; }
        //}

        public Looper(Form1 theDisplay, int start, int end)
        {
            this.start = start;
            this.end = end;
            this.theDisplay = theDisplay;

        }

        /// <summary>
        /// Display
        /// </summary>
        /// <param name="validatorDel"></param>
        public void Display(ValidateNumber validatorDel)
        {
            for (int i = start; i < end; i++)
            {

                if (validatorDel != null)
                {
                    if (validatorDel(i))
                        theDisplay.tbOutput.Text += i + Environment.NewLine;
                }
                else
                {
                    theDisplay.tbOutput.Text += i + Environment.NewLine;
                }
            }
        }






        #region version without delegate, but with an interface
        IValidate valid = null;

        public IValidate Valid
        {
            get { return valid; }
            set { valid = value; }
        }

        public void Display2()
        {
            for (int i = start; i < end; i++)
            {
                if (Valid != null && Valid.isValid(i))
                {
                    theDisplay.tbOutput.Text += i + Environment.NewLine;
                }
            }
        }
        #endregion
    }
}
