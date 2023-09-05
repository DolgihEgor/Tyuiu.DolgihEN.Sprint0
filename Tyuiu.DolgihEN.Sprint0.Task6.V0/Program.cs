using System;
using System.Collections.Generic;
using System.Linq; 
using System.Text;
using System.Threading.Tasks;
using Tyuiu.DolgihEN.Sprint0.Task6.V0.Lib;

namespace Tyuiu.DolgihEN.Sprint0.Task6.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numsArray = new int[] { 1, 2, 3, 4, 5 };

            //Пример AdditionArray
            Console.WriteLine("Сумма элементов массива =" + DataService.AdditionArray(numsArray));
            //Пример SubtractionArray
            Console.WriteLine("Разность эллементов массива =" + DataService.SubtractionArray(numsArray));
            //Пример MultiplicationArray
            Console.WriteLine("Произведение элементов массива =" + DataService.MultiplicationArray(numsArray));
            Console.ReadKey();
        }
    }
}
