//把重複出現過的數字顯示出來

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomArray
{
    class Program
    {
        private const int arraySize = 100;
        private static Random randomNum = new Random();
        static void Main(string[] args)
        {
            int[] data = new int[arraySize];
            int[] fre = new int[1000];
            //DataGen(data);
            DataGen2(data, fre);
            OutputArray(data);
            RecurrentNumbers(fre);
            Console.ReadKey();

        }
        
        public static void DataGen(int[] numbers)//節省空間的產生不重複亂數的方法
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = randomNum.Next(1, 1000);
                for (int j = i - 1; j >= 0; j--)//避免產生重複的數字
                {
                    if (numbers[i] == numbers[j])
                    {
                        i--;
                        break;
                    }
                }
            }
        }

        public static void DataGen2(int[] numbers, int[] fre)//節省時間的產生不重複的亂數的方法
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = randomNum.Next(1, 1000);

                if (fre[numbers[i]] != 0)
                {
                    Console.Write("{0, 4}", numbers[i]);
                    Console.WriteLine();
                    fre[numbers[i]]++;
                    i--;
                }
                else
                {
                    fre[numbers[i]]++;
                }
            }
        }

        public static void RecurrentNumbers(int[] fre)
        {
            Console.WriteLine("重複出現過的數字");
            for (int i = 0; i < 1000; i++)
            {
                if (fre[i] > 1)
                {
                    Console.WriteLine("{0}，出現過{1}次",i,fre[i]);
                }
            }
        }

        public static void OutputArray(int[] numbers)//輸出
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("{0, 4}", numbers[i]);
                if ((i + 1) % 10 == 0)
                    Console.WriteLine();
            }
        }
    }
}
