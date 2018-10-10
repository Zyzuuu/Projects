using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pesel
{
    public class Data
    {
        int Sum = 0;
        public void ArrayData()
        {
            Console.WriteLine("NR PESEL DO WERYFIKACJI: ");
            int[] array = new int[11];
            int[] MultiplyArray = new int[11] { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3, 1 };

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int j = 0; j < array.Length; j++)
            {
                var Multiply = array[j] * MultiplyArray[j];
                Sum += Multiply;
                Console.Clear();
            }

            var check = Sum % 10;

            if (Sum > 0 && check == 0 && Sum != 0)
            {
                Console.Write("NR PESEL DO WERYFIKACJI:  ");
               
                for (int j = 0; j < array.Length; j++)
                {
                    Console.Write( array[j]);
                }
                Console.WriteLine("");
                
                Console.WriteLine("SUMA KONTROLNA (OSTATNIA CYFRA == 0): " + Sum);
                Console.WriteLine("PESEL JEST PRAWIDŁOWY");
            }
            else
            {
                Console.WriteLine("SUMA KONTROLNA (OSTATNIA CYFRA != 0): " + Sum);
                Console.WriteLine("PESEL JEST BŁĘDNY");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Data o1 = new Data();
            o1.ArrayData();

            Console.Read();
        }
    }
}
