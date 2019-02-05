using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOnStructAndEnumeration
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee= new Employee();
            Console.WriteLine("Наша организация состоит из 6 человек (включая Директора).\n" +
                "Их список указан ниже:\n" +
                "________________________");
            employee.InitAndShowVacancies();

            Console.ReadLine();
        }
    }
}
