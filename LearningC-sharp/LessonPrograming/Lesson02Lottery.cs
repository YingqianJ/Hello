using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lottery
{
    class Program
    {
        //產生樂透的六個不重複數字的method
        static void GenerateNumber(int[] numbers)
        {
            bool[] choose = new bool[50];//浪費一個位置:第一個不用
            Random rand = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                int temp;
                temp = rand.Next(1, 50);//放入1-49的數值到第i個位置中
                if (choose[temp] == true)
                {
                    i--;//這次不算
                }
                else
                {
                    numbers[i] = temp;
                    choose[temp] = true;//標示此數字已被選
                }
            }
        }


        //輸出陣列內容的method
        static void WriteNumber(int[] numbers)
        {
            foreach (int val in numbers)
            {
                Console.WriteLine(val);
            }
        }

        //兌獎的method
        static int CheckOut(int[] numbers, int[] bingo, int[] result)
        {
            int answer = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                for(int i2 = 0; i2 < bingo.Length; i2++)
                {
                    if (numbers[i] == bingo[i2])
                    {
                        result[answer] = numbers[i];//把中獎的號碼放入result中
                        answer++;
                    }
                }
            }
            return answer;
        }

        static void Main(string[] args)
        {
            //宣告有六個元素的陣列
            const int size = 6;
            int[] numbers = new int[size];//電腦選號
            int[] bingo = new int[size];//中獎號碼
            int[] result = new int[size];//兌獎結果
            int answer = 0;

            Console.WriteLine("電腦選號結果為");
            GenerateNumber(numbers);//產生電腦選號
            WriteNumber(numbers);
            Console.WriteLine("中獎號碼為");
            GenerateNumber(bingo);//產生中獎號碼
            WriteNumber(bingo);

            //兌獎
            answer = CheckOut(numbers, bingo, result);
            if(answer != 0)
            {
                Console.WriteLine("恭喜你中獎了號碼是");
                for(int i = 0; i < answer; i++)
                {
                    Console.WriteLine(result[i]);
                }
            }
            else
            {
                Console.WriteLine("很遺憾你沒有中獎!");
            }

            Console.ReadKey();
        }
    }
}

