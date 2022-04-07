using System;
using System.Collections.Generic;
using System.Text;

namespace _04082022
{
    internal class Data
    {
        static Dictionary<string ,double>_studens=new Dictionary<string ,double>();
        public static Dictionary<string ,double> Studens { get { return _studens; } }
        public int No { get;set; }
        public Data(int no)
        {
            this.No = no;
        }
    }
}
