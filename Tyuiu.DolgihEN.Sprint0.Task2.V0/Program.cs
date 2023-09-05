using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.DolgihEN.Sprint0.Task2.V0.Lib;

namespace Tyuiu.DolgihEN.Sprint0.Task2.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вызов класса DataService
            //Из библиотек .Lib
            Console.WriteLine(DataService.GetMessage("Егор"));
            Console.ReadKey();
        }
    }
}
