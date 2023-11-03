using System;
using System.Security.Cryptography.X509Certificates;

internal class Program//class

//parameters
{
    int w = 15;//field

    decimal j = 25;

    private static void Main(string[] args)//method
    {
        Console.WriteLine("great");
        Calculator(15,27);
        Numbers(23, 98);
        Alphabets(33, 78);
        dollar(34, 67,34);


    }

    public static void Calculator(int s, int y)
    {
        int w = s + y;
        Console.WriteLine(w);
    }
    public static void Numbers(decimal g, decimal h)
    {
        decimal j = g + h;
        Console.WriteLine(j);

    }
    public static void Alphabets(int value1, int value2)
    {
          int Alphabets = value1 + value2;
         Console.WriteLine(Alphabets);
    }
   public static void dollar(decimal value1, decimal value2,decimal value3)
    {
             decimal book = value1 - value2 +value3;
        Console.WriteLine(Numbers);
    }



}