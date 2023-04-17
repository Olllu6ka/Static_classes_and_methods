using System;

namespace _5
{
    class Program
    {
        //Используя Visual Studio, создайте проект по шаблону Console Application.
        //Создайте класс, который будет описывать точку в трехмерной системе координат(X, Y, Z). В теле
        //класса переопределите операторы сложения(+), вычитания(-), умножения(*), деления(/),
        //декремента(++), инкремента(--), также переопределите метод ToString(), таким образом, чтоб он
        //отображал полную информацию о точке(ее координаты), метод Equals для сравнения 2-х точек,
        //а также метод GetHashCode.В методе Main() создайте 2 экземпляря класса точка, выполните
        //для 2-х точек все переопределенные методы, результат выполнения операция вывидите на
        //консоль.
        static void Main(string[] args)
        {
            Console.Write("Точка А - х: ");
            int Ax = int.Parse(Console.ReadLine());
            Console.Write("Точка А - y: ");
            int Ay = int.Parse(Console.ReadLine());
            Console.Write("Точка А - z: ");
            int Az = int.Parse(Console.ReadLine());
            Console.Write("Точка B - х: ");
            int Bx = int.Parse(Console.ReadLine());
            Console.Write("Точка B - y: ");
            int By = int.Parse(Console.ReadLine());
            Console.Write("Точка B - z: ");
            int Bz = int.Parse(Console.ReadLine());
            Dot dot = new Dot();
            Console.Write("Выберите что хотите сделать"+ "\nСложения(+)" + "\tВычитания(-)" + "\tУмножения(*)"+ 
                "\nДеления(/)"+ "\tДекремента(++)"+ "\tИнкремента(--)"+ "\tСравнение(=)" +"\nВведите что вы выбрали в (): ");
            string Function = Console.ReadLine();
            switch (Function)
            {
                case "+":
                    dot.Plus(Ax, Ay, Az, Bx, By, Bz);
                    dot.ToString();
                    break;
                case "-":
                    dot.Minus(Ax, Ay, Az, Bx, By, Bz);
                    dot.ToString();
                    break;
                case "*":
                    dot.Multiply(Ax, Ay, Az, Bx, By, Bz);
                    dot.ToString();
                    break;
                case "/":
                    dot.Division(Ax, Ay, Az, Bx, By, Bz);
                    dot.ToString();
                    break;
                case "++":
                    Console.WriteLine("Введите какую точку");
                    int FunctionT = int.Parse(Console.ReadLine());
                    if (FunctionT == 1){
                        dot.Increment(Ax, Ay, Az);
                        dot.ToString();
                    }
                    else{
                        dot.Increment(Bx, By, Bz);
                        dot.ToString();
                    }
                    break;
                case "--":
                    Console.WriteLine("Введите какую точку");
                    int FunctionT1 = int.Parse(Console.ReadLine());
                    if (FunctionT1 == 1){
                        dot.Decrement(Ax, Ay, Az);
                    }
                    else{
                        dot.Decrement(Bx, By, Bz);
                    }
                    break;
                case "=":
                    dot.EqualsT();
                    break;
            }
           
        }
    }
    class Dot
    {
        public int [] Point = new int[4];
        public int [] Point1 = new int[4];
        public void Plus(int Xx, int Xy,int Xz,int Cx,int Cy,int Cz){
            Console.WriteLine("Сложение точки 2");
            Point1[0] = (Xx + Cx);
            Point1[1] = (Xy + Cy);
            Point1[2] = (Xz + Cz);
            Console.WriteLine("К вашей точке добавлены числа "); ;
                  
        }
        public void Minus(int Xx, int Xy, int Xz, int Cx, int Cy, int Cz){
            Console.WriteLine("Отнимаем точки");
            Console.Write("Введите что вы хотите сложить:"+"\n1)Отнимаем от 1"+ "\t2)Отнимаем от 2" + "\nВведите цифру в (): ");
            int Fumction = int.Parse(Console.ReadLine());
            switch (Fumction){
                case 1:
                    Point[0] = (Xx - Cx);
                    Point[1] = (Xy - Cy);
                    Point[2] = (Xz - Cz);
                    Console.WriteLine("От точки отняли числа ");
                    break;
                case 2:
                    Point[0] = (Cx + Xx);
                    Point[1] = (Cy + Xy);
                    Point[2] = (Cz + Xz);
                    Console.WriteLine("От точки отняли числа ");
                    break;
            }
            
        }
        public void Multiply(int Xx, int Xy, int Xz, int Cx, int Cy, int Cz){
            Console.WriteLine("Умножение точку 2");
            Point1[0] = (Xx * Cx);
            Point1[1] = (Xy * Cy);
            Point1[2] = (Xz * Cz);
        }
        public void Division(int Xx, int Xy, int Xz, int Cx, int Cy, int Cz){
            Console.WriteLine("Деленрие точек");
            Console.Write("Введите что вы хотите поделить:" + "\n1)Деление на 1" + "\t2)Деление на 2" + "\nВведите цифру в (): ");
            int Fumction = int.Parse(Console.ReadLine());
            switch (Fumction){
                case 1:
                    if (Point[0] != 0 && Point[1] != 0 && Point[2] != 0){
                        Point[0] = (Point[0] / Point1[0]);
                        Point[1] = (Point[1] / Point1[1]);
                        Point[2] = (Point[2] / Point1[2]);
                    }
                    else { Console.WriteLine("Одно из x,y,z = 0"); }
                    break;
                case 2:
                    if (Point1[0] != 0 && Point1[1] != 0 && Point1[2] != 0){
                        Point1[0] = (Point1[0] / Point1[0]);
                        Point1[1] = (Point1[1] / Point1[1]);
                        Point1[2] = (Point1[2] / Point1[2]);
                    }
                    else { Console.WriteLine("Одно из x,y,z = 0"); }
                    break;
            }
        }
        public void Decrement(int Xx, int Xy, int Xz)
        {
            Point[0] = Point[0]--;
            Point[1] = Point[1]--;
            Point[2] = Point[2]--;
        }
    public void Increment(int Xx, int Xy, int Xz)
    {
            Point[0] = Point[0]++;
            Point[1] = Point[1]++;
            Point[2] = Point[2]++;
        }
    public void ToString()
    {
            Console.Write("Какую вывести вам точку?"+"\n(1)"+"\t(2)"+"\nВведите: ");
            int Function = int.Parse(Console.ReadLine());
            if (Function == 1){
                Console.WriteLine("Tochka 1");
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine(Point[i]);
                }
            }
            else{
                Console.WriteLine("Tochka 2");
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine(Point1[i]);
                }
            }
        }
    public void EqualsT()
    {
        if (Point[0] == Point1[0] && Point[1] == Point1[1] && Point[2] == Point1[2])
        {
            Console.WriteLine("Они одинаковы");
        }
        else
        {
            Console.WriteLine("Не одинаковы !");
        }
    }
    void GetHashCode()
    {

    }
}
}
