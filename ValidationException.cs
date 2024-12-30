using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagementApp
{
    public class ValidationException : Exception
    {
        public ValidationException(string message) : base (message) 
        {
        
        }
        public override string ToString()
        {
            return $"validation error : {Message}";
        }
    }
}
