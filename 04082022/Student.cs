using System;
using System.Collections.Generic;
using System.Text;

namespace _04082022
{
    internal class Student
    {
        public int No { get; set; } 
        public string FullName { get; set; }
        public Student(string fullname,int no)
        {
            No = no;
            FullName = fullname;
        }
    }
}
