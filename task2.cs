using System;

public class Product
{
    public string Name;
    public int Price;
}

public class Milk : Product
{
    public double FatPercent;
}

public class Program
{
    public static void Main(string[] args)
    {
        Milk milk1 = new Milk { Name ="milka", Price = 2,FatPercent = 2.5 };
        Milk milk2 = new Milk { Name = "milk", Price = 5,FatPercent = 3.2 };
        Milk milk3 = new Milk { Name = "palsud", Price = 3, FatPercent = 3.6 };
        Milk[] milks = { milk1, milk2, milk3 };
       double yagliqfaizinincemi = 0;
     foreach(Milk milk in milks)
        {
            yagliqfaizinincemi += milk.FatPercent;
        }
        double  ort = yagliqfaizinincemi / milks.Length;
        Console.WriteLine(ort);
    }
}
