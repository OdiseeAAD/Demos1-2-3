using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class MyCustomException: Exception
    {
        public MyCustomException():base("Mijn eigen custom exception")
        {
            
        }
    }
}
