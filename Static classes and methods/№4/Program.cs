using System;
using System.Linq;

namespace _4
{
    class Program
    {
        //Используя Visual Studio, создайте проект по шаблону Console Application.
        //Создайте в программу, в которой создайте статический класс, в теле которого создайте
        //расширяющий метод, который будет сортировать элементы целочисленного массива по
        //возрастанию.Также в теле класса создайте метод, который будет создавать массив
        //целочисленных элементов, и заполнять его случайными значениями элементов, длина массива –
        //параметр метода.В методе Main() с помощью метода описанного выше создайте массив
        //целочисленных элементов размерностью 10 элементов, выведите значение всех элементов
        //массива на консоль, далее с помощью расширяющего метода отсортируйте массив, и
        //отсортированный массив снова выведите на консоль.
        static void Main(string[] args)
        {
            Console.WriteLine("Создаем масив");
            ArrayNumbers.ArrayCreate();
            Console.Write("\nСортировка масива ");
            ArrayNumbers.SortArray(ArrayNumbers.array1);
           
        }
    }
    static class ArrayNumbers
    {
       public static int[] array1 = new int[10];
        public static void ArrayCreate(){
            Random random = new Random();
            for (int i = 0; i < array1.Length; i++){
                array1[i] = random.Next(0, 20);
            }
            Console.WriteLine("Вывод масива: ");
            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine(array1[i]);
            }
        }
        public static void SortArray(int [] array)
        {
            int currentMin = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                int current = int.MaxValue;
                int minCount = 0;
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[j] < current && array[j] > currentMin)
                    {
                        current = array[j];
                        minCount = 0;
                    }
                    if (array[j] == current)
                        minCount++;
                }
                while (minCount-- > 0)
                    Console.WriteLine(current);
                currentMin = current;
            }
        }

    }
}
