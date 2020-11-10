using System;

namespace ConsoleApplication1
{
    class Program
    {
        //找出最大值的method
        static int FindMax(int n1, int n2, int n3)
        {
            int max;
            max = n1;
            if (max < n2)
            {
                max = n2;
            }
            if (max < n3)
            {
                max = n3;
            }
            return max;
        }
        
        //找出最大公因數的method
        static int Findgcd(int n4, int n5)
        {
            int gcd=1;
            int i;
            for (i = 1; i <= n4 && i <= n5; i++)
            {
                if (n4 % i == 0 && n5 % i == 0)//i能同時被n4, n5整除(兩數的公因數)
                {
                    gcd = i;
                }
            }
            return gcd;
        }
        
        //找出3個數比大小的method
        static int Compare(int n6, int n7, int n8)
        {
            int max1, min, middle;
            max1 = n6;
            middle = n7;
            if (max1 < n7)
            {
                max1 = n7;
                min = n6;
            }
            else
            {
                min = n7;
            }
            if (max1 < n8)
            {
                middle = max1;
                max1 = n8;
            }
            else if (min > n8)
            {
                middle = min;
                min = n8;
            }
            return max1;
        }

        static void Main(string[] args)
        {
            //找出最大值
            int n1, n2, n3;
            int max;
            Console.WriteLine("please enter number 1 : ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter number 2 : ");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter number 3 : ");
            n3 = Convert.ToInt32(Console.ReadLine());
            max = FindMax(n1, n2, n3);//調用method
            Console.WriteLine("Max is:" + max);
            
            //找出最大公因數
            int gcd = 1;
            Console.WriteLine("please enter number 4 : ");
            int n4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter number 5 : ");
            int n5 = Convert.ToInt32(Console.ReadLine());
            gcd = Findgcd(n4, n5);
            Console.WriteLine("gcd is:" + gcd);
            
            //3個數比大小
            int n6, n7, n8;
            Console.WriteLine("please enter number 6 : ");
            n6 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter number 7 : ");
            n7 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter number 8 : ");
            n8 = Convert.ToInt32(Console.ReadLine());
            int max1, middle, min;
            max1 = Compare(n6, n7, n8);//調用method 
            middle = Compare(n6, n7, n8);//這裡能否調用到method中middle的值？
            min = Compare(n6, n7, n8);
            Console.WriteLine(max1 + ">" + middle + ">" + min);
            Console.ReadKey();
        }
    }
}

