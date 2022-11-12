using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10_Exeptions
{
    public class WrongPasswordException : Exception
    {
        public WrongPasswordException(string message) : base(message)
        {
            message = this.Message;
        }

    }

    public class WrongLoginException : Exception
    {
        public WrongLoginException (string message): base(message)
        {
           message=this.Message;
        }
    }
}
