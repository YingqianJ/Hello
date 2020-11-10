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
            //DataGen(data);
            DataGen2(data);
            OutputArray(data);
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

        public static void DataGen2(int[] numbers)//節省時間的產生不重複的亂數的方法
        {
            int[] fre = new int[1000];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = randomNum.Next(1, 1000);
                if (fre[numbers[i]] != 0)
                {
                    i--;
                }
                fre[numbers[i]]++;
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
