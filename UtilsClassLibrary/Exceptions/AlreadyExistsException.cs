using System;
using System.Collections.Generic;
using System.Text;

namespace UtilsClassLibrary.Exceptions
{
    public class AlreadyExistsException : Exception
    {
        public AlreadyExistsException(string message) : base(message)
        {

        }
    }
}
