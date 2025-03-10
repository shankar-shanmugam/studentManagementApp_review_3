﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagementApp
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Age { get; set; }
        public string Grade { get; set; }

        public override string ToString()
        {
            return $"studentId : {Id}\n studentName :{Name}\n studentEmail : {Email}\n studentAge : {Age}\n studentGrade :{Grade}";
        }

    }
}
