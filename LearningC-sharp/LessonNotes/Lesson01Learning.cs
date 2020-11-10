//輸入三個數的四種方法
//1
            int f, g, h;
            bool check;
            Console.WriteLine("please enter 3 numbers: ");
            check = int.TryParse(Console.ReadLine(), out f); //把上面第一個輸入的數值寫入f中
            check = int.TryParse(Console.ReadLine(), out g); //把上面第二個輸入的數值寫入g中
            check = int.TryParse(Console.ReadLine(), out h);

//2
            int a, b, c;
            Console.WriteLine("please enter number 1 : ");
            a = Convert.ToInt32(Console.ReadLine());//把上面輸入的數值寫入a中，covert是把string轉為int
            Console.WriteLine("please enter number 2 : ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter number 3 : ");
            c = Convert.ToInt32(Console.ReadLine());

//3
            Console.WriteLine("please enter number 1 : ");
            int a = Convert.ToInt32(Console.ReadLine());//把上面輸入的數值寫入a中
            Console.WriteLine("please enter number 2 : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter number 3 : ");
            int c = Convert.ToInt32(Console.ReadLine());

//4利用陣列
            int i;
            int []a = new int[4];//宣告一個有四個元素的a陣列
            for (i = 1; i<4; i++)
            {
                Console.Write("please enter number" + i + ": ");
                a[i] = int.Parse(Console.ReadLine());//把上面輸入的數值寫入陣列特定位置中(第一個數值寫入a[1]，第二個寫入a[2])
            }




//找出三數中最大的method:
//1
        static void Main(string[] args)
        {
            int i;
            int []a = new int[4];//宣告一個有四個元素的a陣列
            for (i = 1; i<4; i++)
            {
                Console.Write("please enter number" + i + ": ");
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(); //空行
            Console.WriteLine("Max is:{0}", a.Max()); //用Max的方法
            Console.ReadLine();
        }


//2
        static void Main(string[] args)
        {
            int a, b, c;
            int max;
            Console.WriteLine("please enter number1: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter number2: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter number3: ");
            c = Convert.ToInt32(Console.ReadLine());
            max = a;
            if (max < b)
            {
                max = b;
            }
            if (max < c)
            {
                max = c;
            }
            Console.WriteLine("Max is:" + max);
            Console.ReadLine();//讓程式運行完不會自動關閉,也可用Console.ReadKey();等待按下任意鍵
        }

//3
        static void Main(string[] args)
        {
            int i;
            int []a = new int[4];
            int max;
            for(i=1; i<4; i++)
            {
                Console.Write("please enter number" + i + ": ");
                a[i] = int.Parse(Console.ReadLine());
            }
            max = a[1];
            if (max < a[2])
            {
                max = a[2];
            }
            if (max < a[3])
            {
                max = a[3];
            }
            Console.WriteLine("Max is:" + max);
            Console.ReadLine();
        }
