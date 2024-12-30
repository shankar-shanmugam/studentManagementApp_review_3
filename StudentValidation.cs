using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace StudentManagementApp
{
    internal class StudentValidation
    {
        public bool ValidateName(string name)
        {
            string pattern = @"^[a-zA-Z]+(\s|-)?[a-zA-Z]+$";
            return Regex.IsMatch(name, pattern);
        }

        public bool ValidateEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9+-_.]+@[a-z]{5,}\.[a-z]{2,}$";
            return Regex.IsMatch(email, pattern);
        }
        
        public bool ValidateAge(string age)
        {
            string pattern = @"^(1[0-9]|2[0-5]|[5-9])$";
            return Regex.IsMatch (age, pattern);    
        }

        public bool ValidateGrade(string grade)
        {
            string pattern = @"^[A-F]{1}$";
            return Regex.IsMatch(grade, pattern);
        }
    }
}
