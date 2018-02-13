using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trpz1_01
{
    class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Ведите количество чисел для сортировки.");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите числа для сортировки:");
            int[] mas = new int[N];
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = Convert.ToInt32(Console.ReadLine());
            }
            SortetContainer.ViborSort(mas);
            Console.WriteLine("Отсортированный массив:");
            for (int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine(mas[i]);
            }
            Console.ReadLine();
        }

    }
}
