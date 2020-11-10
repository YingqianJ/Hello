//array
//全班45人，隨機產生每個學生的成績，並加總及算平均
using System;


namespace lotteryNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            const int SIZE = 45;

            int[] lotteryNumbers;//宣告陣列變數
            lotteryNumbers = new int[SIZE];//產生變數參考的物件
            //將上述兩行寫成一行為 int[] lotteryNumbers = new int[SIZE];

            int sum = 0, average;

            //Create a Random object
            Random rand = new Random();

            for (int i = 0; i < lotteryNumbers.Length; i++)//input資料
            {
                lotteryNumbers[i] = rand.Next(100);//隨機產生一個0-100的數字，放到第i個位置中
                sum = sum + lotteryNumbers[i];//加總
            }

            //用foreach來output資料
            //foreach(int val in lotteryNumbers)
            //{
            //    Console.WriteLine(val);
            //}

            //用for來output資料
            for (int i = 0; i < lotteryNumbers.Length; i++)
            {
                Console.WriteLine("student" + (i+1) + ": " + lotteryNumbers[i]);
            }

            average = sum / lotteryNumbers.Length;
            Console.WriteLine("The sum is " + sum + ".");
            Console.WriteLine("The average is " + average + ".");
            Console.ReadKey();

        }
    }
}
