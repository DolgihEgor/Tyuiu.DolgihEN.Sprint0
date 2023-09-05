using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.DolgihEN.Sprint0.Task5.V0.Lib
{
    public class DataService
    {
        // Сложение
        public static int Addition(int a, int b)
        {
            return a + b;
        }

        // Вычитание 
        public static int Subtraction(int a, int b)
        {
            return a - b;
        }

        //Умножение
        public static int Multiplication(int a, int b)
        {
            return a * b;
        }
        //Деление
        public static int Division(int a, int b)
        {
            if (b == 0)
            { 
                Console.WriteLine("Переменная b = {0} На ноль делить нельзя", b);
                return -1;
            }
            else
            {
                return a / b;
            }
        }

    }
}
