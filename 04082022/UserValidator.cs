using System;
using System.Collections.Generic;
using System.Text;

namespace _04082022
{
    internal class UserValidator
    {
        public bool CheckDictionary(string exam)
        {
            if(Data.Studens.ContainsKey(exam))
            {
                return true;
            } 
            return false;
        }
    }
}
