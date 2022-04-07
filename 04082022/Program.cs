using System;
using System.Collections.Generic;

namespace _04082022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student>students=new List<Student>();
            UserCrud userCrud=new UserCrud();   
            UserValidator userValidator=new UserValidator();
            bool check = true;
            do
            {
                Console.WriteLine("1. Telebe elave et");
                Console.WriteLine("2. Telebeye imtahan elave et");
                Console.WriteLine("3. Telebenin bir imtahan balına bax");
                Console.WriteLine("4. Telebenin bütün imtahanlarını göster");
                Console.WriteLine("5. Telebenin imtahan ortalamasını göster");
                Console.WriteLine("6. Telebeden imtahan sil");
                Console.WriteLine("0. Proqramı bitir");
                string choise=Console.ReadLine();
                switch (choise)
                {
                    case "1":
                        Console.WriteLine("Ad daxil edin");
                        string FullName=Console.ReadLine();
                        bool IsInt;
                        Console.WriteLine("No daxil edin");
                        string noStr=Console.ReadLine();
                        int no;
                        IsInt=int.TryParse(noStr, out no);
                        students.Add(new Student(FullName, no));

                        break;
                        case "2":
                        Console.WriteLine("Imtahan adinizi daxil edin");
                        string examName=Console.ReadLine();
                        double point;
                        Console.WriteLine("Qiymet daxil edin");
                        string pointStr=Console.ReadLine();
                        bool IsDouble;
                        IsDouble=double.TryParse(pointStr, out point);
                        userCrud.AddExam(examName, point);

                        break;
                        case"3":
                        Console.WriteLine("Axtardiqiniz Imtahan adini daxil edin");
                        string searchExam = Console.ReadLine();
                        while (userValidator.CheckDictionary(searchExam))
                        {
                            Console.WriteLine("Adi duzgun daxil edin");
                            searchExam = Console.ReadLine();
                        }
                        Console.WriteLine(userCrud.GetExamResult(searchExam));
                        break;
                        case"4":
                        userCrud.ShowInfo();
                        break;
                        case"5":
                        Console.WriteLine("Ortalama qiymet");
                        Console.WriteLine(userCrud.GetExamAvg());
                        break;
                        case"6":
                        Console.WriteLine("Silmek istediyiniz Exami daxil edin");
                        string removeExamName = Console.ReadLine();
                            userCrud.RemoveExam(removeExamName);
                        break;
                    case "0":
                        check = false;
                        break;
                    default:
                        break;
                }

            } while (check);
        }
    }
}
