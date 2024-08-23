using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_SimpleDelegate
{
    class Even : IValidate
    {
        public bool isValid(int number)
        {
            return number % 2 == 0;
        }
    }
}
