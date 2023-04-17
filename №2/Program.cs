using System;

namespace _2
{
    class Program
    {
        //Используя Visual Studio, создайте проект по шаблону Console Application.
        //Создайте программу, в которой создайте статический класс Convector(конвектор). В теле класса
        //Convector создайте два статических метода, первый CelsiusToFahrenheit(string temperatureCelsius)
        //, который конвертирует значение температуры в Цельсиях в Фаренгейты, и второй
        //FahrenheitToCelsius(string temperatureFahrenheit), который конвертирует значение температуры в
        //Фаренгейтах в значение температуры в Цельсиях.Организуйте возможность взаимодействия
        //ользователя с программой.
        static void Main(string[] args)
        {
            Console.Write("Меню"+ "\nЦельсиях" +"\tФаренгейты"+"\nВведите что вы хотите узнать: ");
            string Function = Console.ReadLine();
            if (Function == "Фаренгейты")
            {
                Console.Write("Введите температуру в Цельсиях: ");
                int TemperatureC = int.Parse(Console.ReadLine());
                Convector.CelsiusToFahrenheit(TemperatureC);
            }
            else if (Function == "Цельсиях")
            {
                Console.Write("Введите температуру в Фаренгейт: ");
                int TemperatureF = int.Parse(Console.ReadLine());
                Convector.FahrenheitToCelsius(TemperatureF);
            }
        }
    }
    static class Convector
    {
        public static void CelsiusToFahrenheit(int temperatureCelsius){
            int TemperatureF = ((temperatureCelsius * 9) / 5) + 32;
            Console.WriteLine(TemperatureF + " - Температура в Фаренгейты");
        }
        public static void FahrenheitToCelsius(int temperatureFahrenheit){
            int TemperatureC = (((temperatureFahrenheit - 32) * 5) / 9);
            Console.WriteLine(TemperatureC + " - Температура в Цельсиях");
        }
    }
}