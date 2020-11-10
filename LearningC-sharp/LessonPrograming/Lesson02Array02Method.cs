//以後先以method的形式寫

using System;


namespace Scores
{
    class Program
    {
        static void ReadScores(int[] scores)//input資料的method
        {
            //Create a Random object
            Random rand = new Random();

            for (int i = 0; i < scores.Length; i++)
            {
                scores[i] = rand.Next(30,100);//隨機產生一個30-100的數字，放到第i個位置中
            }

        }

        static void WriteScores(int[] scores)//output資料的method
        {
            //用foreach來output資料
            //foreach(int val in scores)
            //{
            //    Console.WriteLine(val);
            //}

            //用for來output資料
            for (int i = 0; i < scores.Length; i++)
            {
                Console.WriteLine("student" + (i + 1) + ": " + scores[i]);
            }
        }

        static int HighestScores(int[] scores)//找最高分的method
        {
            int answer = 0;
            foreach(int val in scores)
            {
                if (val > answer)
                {
                    answer = val;
                }
            }
            return answer;
        }

        static double AverageScores(int[] scores) //算平均數的method
        {
            int sum = 0;
            double average = 0;
            for (int i = 0; i < scores.Length; i++)
            {
                sum = sum + scores[i];
            }

            average = (double)sum / scores.Length;//(double)使sum強行轉換，避免int除以int無條件四捨無入的情況，效果同average = sum / 45.0
            return average;
        }
        static void Main(string[] args)
        {
            const int SIZE = 45;//使size為常數，靜態不可改變

            int[] scores; //宣告陣列
            scores = new int[SIZE];//產生變數參考的物件
            //將上述兩行寫成一行為 int[] scores = new int[SIZE];

            int high; //儲存最高分數
            double average; //儲存平均數

            ReadScores(scores);//呼叫method
            WriteScores(scores);
            high = HighestScores(scores);
            average = AverageScores(scores);

            Console.WriteLine("最高分為: " + high);
            Console.WriteLine("平均分為: " + average);
            Console.ReadKey();

        }
    }
}
