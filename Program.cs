using System;
using MyDateTime = System.DateTime;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Демонстрацiя використання псевдонiмiв типiв.");
        Console.WriteLine("--------------------------------------------");
        MyDateTime currentTime = MyDateTime.Now;
        Console.WriteLine($"Поточна дата та час: {currentTime}");
        Console.WriteLine("--------------------------------------------");
    }
}