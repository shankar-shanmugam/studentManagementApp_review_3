using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagementApp
{
    internal class StudentNotFoundException : Exception
    {
        public StudentNotFoundException(string name) : base(name) 
        {

        }
    }
}
