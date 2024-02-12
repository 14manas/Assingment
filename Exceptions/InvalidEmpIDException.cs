using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CManagement.Exceptions
{
    internal class InvalidEmpIDException
    {
        public InvalidEmpIDException()
        {

        }
        public InvalidEmpIDException(string message) : base(message)
        {

        }
    }
}
