using System;

public class TaxCalculator
{
    public static void Main(String[] args)
    {
        double prize;
        string state;
        Console.Write("購物金額多少錢？");
        prize = Convert.ToInt32(Console.ReadLine());
        Console.Write("你住在哪一個州？");
        state = Console.ReadLine();

        double taxRate;
        if (state == "wisconsin")
            taxRate = 0.05;
        else if (state == "illinois")
            taxRate = 0.08;
        else
            taxRate = 0.03;

        double tax = prize * taxRate;
        double totalPrize = tax + prize;
        Console.Write("The tax is $" + tax + ".");
        Console.Write("The total is $" + totalPrize + ".");
        Console.ReadKey();

    }
}
