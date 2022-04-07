using System;
using System.Collections.Generic;
using System.Text;

namespace _04082022
{
    internal class UserCrud
    {
        public void AddExam(string examName,double point)
        {
            Data.Studens.Add(examName,point);
        }
        public double GetExamResult(string examName)
        {
            return Data.Studens.GetValueOrDefault(examName);
        }
        public double GetExamAvg()
        {
            double sum = 0;
            foreach (var item in Data.Studens)
            {
                sum += item.Value;
            }
            sum /= Data.Studens.Count;
            return sum;
        }
        public void RemoveExam(string examName)
        {
            Data.Studens.Remove(examName);
        }
        public void ShowInfo()
        {
            foreach (var A in Data.Studens)
            {
                Console.WriteLine("Exam={0}",A);
            }
        }
    }
}
