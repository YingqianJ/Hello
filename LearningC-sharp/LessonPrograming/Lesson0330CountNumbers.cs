//有200個學生，0-100分，統計每個分數區間的人數

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomArray
{
    class Program
    {
        private const int arraySize = 200;
        private const int maxNum = 101;
        private static Random randomNum = new Random();
        static void Main(string[] args)
        {
            int[] data = new int[arraySize];
            int[] fre = new int[11];

            //DataGen(data);
            //DataGen2(data, fre);

            DataGen3(data, fre);
            
            OutputArray(data);
            
            RecurrentNumbers(fre);
            
            Console.ReadKey();

        }

        public static void DataGen(int[] numbers)//節省空間的產生不重複亂數的方法
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = randomNum.Next(1,maxNum);
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
                numbers[i] = randomNum.Next(1, maxNum);

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

        public static void DataGen3(int[] numbers, int[] fre)//產生100個介於0-100的整數，允許重複
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = randomNum.Next(0, maxNum);
                fre[numbers[i]/10]++;
            }
        }

        public static void RecurrentNumbers(int[] fre)//統計每個數字出現的次數
        {
            Console.WriteLine("每個分數段的人數");
            for (int i = 0; i <11; i++)
            {
                if (fre[i] > 0)
                {
                    Console.WriteLine("{0}~{1} 有{2}人", i*10,(i+1)*10-1, fre[i]);
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
