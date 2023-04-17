using System;
using System.Linq;

namespace _3
{
    class Program
    {
        //Используя Visual Studio, создайте проект по шаблону Console Application.
        //Создайте программу, в которой создайте статический класс StringExtension(длина строки), в теле
        //класса создайте расширяющий метод StrCount который будет осуществлять подсчёт количество
        //элементов в строке.Возвращаемое значение метода должно быть типа int, на вход необходимо
        //принимать два аргумента, 1-й сама строка, 2-й символ начиная с которого будет производится
        //расчет.

        //Если я не правильно сделал то напишите )
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string Count = Console.ReadLine();
            Console.Write("Введите с какого символа будет расчет: ");
            int CoutNumber = int.Parse(Console.ReadLine());
            StringExtension.StrCount(Count, CoutNumber);
        }
    }
    static class StringExtension
    {
        public static void StrCount(string Coutstr,int CoutstrN) {
            int NumberStr = Coutstr.Length - CoutstrN;
            Console.WriteLine(NumberStr);
        }
    }
}
