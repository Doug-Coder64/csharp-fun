using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Money Maker!");
      Console.WriteLine("Enter the amount to convert:");
    double cents =Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"{cents} cents is equal to...");
    double goldCoins = Math.Floor(cents/10);
    double remainder = cents%10;
    double silverCoins = Math.Floor(remainder/5);
    double bronzeCoins = remainder%5;
    Console.WriteLine($"Gold Coins: {goldCoins}");
    Console.WriteLine($"Silver Coins: {silverCoins}");
    Console.WriteLine($"Bronze Coins: {bronzeCoins}");
    }
  }
}
