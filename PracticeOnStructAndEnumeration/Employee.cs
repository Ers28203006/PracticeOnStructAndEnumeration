using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOnStructAndEnumeration
{
   public enum Vacancies
   {
       Boss,
       Manager, 
       Salesman,
       Clerk,
       Сourier,
       Floorswasher
   };
    public struct Employee
    {
        string name;
        Vacancies worker;
        double salary;
        int[] dateOfEmployment;
        public void InitAndShowVacancies()
        {
            for (worker = Vacancies.Boss; worker <= Vacancies.Floorswasher; worker++)
            {
                switch (worker)
                {
                    case Vacancies.Boss:
                        name = "Иванов Иван Иванович";
                        salary = 10000000;
                        dateOfEmployment = new int[] { 12, 12, 12 };

                        Console.WriteLine("Директор\n" +
                           "ФИО: " + name +
                         "\nЗарплата: " + salary +
                         "\nДата создания фирмы: " + dateOfEmployment[0] + "." + dateOfEmployment[1] + "." + dateOfEmployment[2]);
                        Console.WriteLine("\n************************************\n");
                        break;

                    case Vacancies.Manager:
                        name = "Алиханов Алихан Алиханович";
                        salary = 9000000;
                        dateOfEmployment = new int[] { 12, 10, 13 };

                        Console.WriteLine("Менеджер\n" +
                            "ФИО: " + name +
                          "\nЗарплата: " + salary +
                          "\nДата наема на работу: " + dateOfEmployment[0] + "." + dateOfEmployment[1] + "." + dateOfEmployment[2]);
                        Console.WriteLine("\n************************************\n");
                        break;

                    case Vacancies.Salesman:
                        name = "Иванов Cергей Иванович";
                        salary = 5000000;
                        dateOfEmployment = new int[] { 13, 10, 13 };

                        Console.WriteLine("Финансист\n" +
                             "ФИО: " + name +
                           "\nЗарплата: " + salary +
                           "\nДата наема на работу: " + dateOfEmployment[0] + "." + dateOfEmployment[1] + "." + dateOfEmployment[2]);
                        Console.WriteLine("\n************************************\n");
                        break;

                    case Vacancies.Clerk:
                        name = "Арнольд Шварнегер";
                        salary = 50000;
                        dateOfEmployment = new int[] { 14, 10, 13 };

                        Console.WriteLine("Клерк\n" +
                            "ФИО: " + name +
                          "\nЗарплата: " + salary +
                          "\nДата наема на работу: " + dateOfEmployment[0] + "." + dateOfEmployment[1] + "." + dateOfEmployment[2]);
                        Console.WriteLine("\n************************************\n");
                        break;

                    case Vacancies.Сourier:
                        name = "Скороходов Канат";
                        salary = 20000;
                        dateOfEmployment = new int[] { 15, 12, 13 };

                        Console.WriteLine("Курьер\n" +
                            "ФИО: " + name +
                          "\nЗарплата: " + salary +
                          "\nДата наема на работу: " + dateOfEmployment[0] + "." + dateOfEmployment[1] + "." + dateOfEmployment[2]);
                        Console.WriteLine("\n************************************\n");
                        break;

                    case Vacancies.Floorswasher:
                        name = "Анжелина Джоли";
                        salary = 10000;
                        dateOfEmployment = new int[] { 16, 10, 13 };

                        Console.WriteLine("Техничка\n" +
                            "ФИО: " + name +
                          "\nЗарплата: " + salary +
                          "\nДата наема на работу: " + dateOfEmployment[0] + "." + dateOfEmployment[1] + "." + dateOfEmployment[2]);
                        Console.WriteLine("\n************************************\n");
                        break;
                }
            }
        }
    }
}
