using System;

namespace Static_classes_and_methods
{   
    class Program
    {
        //Используя Visual Studio, создайте проект по шаблону Console Application.
        //Создайте программу, в которой создайте статический класс Calculator(калькулятор). В классе
        //создайте методы для выполнения основных арифметических операций.Реализуйте возможность
        //работы пользователя, через ввод данных с помощью клавиатуры и отображение результат на
        //экран.
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в каркулятор");
            Console.WriteLine("Введите первое число: ");
            int First = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            int Second = int.Parse(Console.ReadLine());
            Console.Write("Меню"+ "\nСложение" + "\tВычитание"+ "\tУмножение"+ "\tДеление"+"\nВведите сдово: ");
            string Function = Console.ReadLine();
            switch (Function){ 
                case "Сложение":
                    Calculator.Plus(First,Second);
                    break;
                case "Вычитание":
                    Calculator.Minus(First, Second);
                    break;
                case "Умножение":
                    Calculator.Multiply(First, Second);
                    break;
                case "Деление":
                    Calculator.Divide(First, Second);
                    break;
            }

        }
    }
    static class Calculator
    {
        public static void Minus(double FirstN, double SecondN)
        {
            Console.Write("С каким числом вы хотите выпольнить действие"+"\nС первым - (1)"+"\tС вторым - (2)"+"\nВведите: ");
            int Function = int.Parse(Console.ReadLine());
            if (Function == 1)
            {
                FirstN = (FirstN - SecondN);
                Console.WriteLine(FirstN);
            }
            else
            {
                SecondN = (SecondN - FirstN);
                Console.WriteLine(SecondN);
            }
        }
        public static void Plus(double FirstN, double SecondN)
        {
            FirstN = (FirstN + SecondN);
            Console.WriteLine(FirstN);
        }
        public static void Divide(double FirstN, double SecondN){
            Console.Write("С каким числом вы хотите выпольнить действие" + "\nС первым - (1)" + "\tС вторым - (2)" + "\nВведите: ");
            int Function = int.Parse(Console.ReadLine());
            if (Function == 1){
                if (SecondN != 0){
                    FirstN = (FirstN / SecondN);
                    Console.WriteLine(SecondN);
                }
                else{
                    Console.WriteLine("Делить на ноль не )");
                }
            }
            else {
                if (FirstN != 0){
                    SecondN = (SecondN / FirstN);
                    Console.WriteLine(SecondN);
                }
                else {
                    Console.WriteLine("Делить на ноль не )");
                }
            }
        }
        public static void Multiply(double FirstN, double SecondN)
        {
            Console.Write("С каким числом вы хотите выпольнить действие" + "\nС первым - (1)" + "\tС вторым - (2)" + "\nВведите: ");
            int Function = int.Parse(Console.ReadLine());
            if (Function == 1)
            {
                FirstN = (FirstN * SecondN);
                Console.WriteLine(FirstN);
            }
            else
            {
                SecondN = (SecondN * FirstN);
                Console.WriteLine(SecondN);
            }
        }
    }

}
