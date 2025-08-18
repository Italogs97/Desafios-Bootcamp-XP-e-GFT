using System;
using CellularSystem.Model;
using CellularSystem.Abstrat;



namespace CellularSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demonstrating Cellular System");

            Cellular iphone = new Iphone("iPhone 16", "11 987569231", 256, "IMEI123456789");
            Cellular samsung = new Samsung("Galaxy S21", "11 987654321", 256, "IMEI987654321");
            Cellular nokia = new Nokia("Nokia 3310", "11 987654321", 16, "IMEI123456789");


            Console.WriteLine("--- Test iPhone ---");
            iphone.TurnOn();
            iphone.MakeCall("987654321");
            iphone.SendMessage("987654321", "Hello from iPhone!");
            iphone.TakePhoto();
            iphone.InstallApp("WhatsApp");
            iphone.TurnOff();
            Console.WriteLine("End of iPhone demonstration.\n");

            Console.WriteLine("--- Test Samsung ---");
            samsung.TurnOn();
            samsung.MakeCall("123456789");
            samsung.SendMessage("123456789", "Hello from Samsung!");
            samsung.TakePhoto();
            samsung.InstallApp("Telegram");
            samsung.TurnOff();
            Console.WriteLine("End of Cellular System demonstration.");

            Console.WriteLine("--- Test Nokia ---");
            nokia.TurnOn();
            nokia.MakeCall("987654321");
            nokia.SendMessage("987654321", "Hello from Nokia!");
            nokia.TakePhoto();
            nokia.InstallApp("Snake");
            nokia.TurnOff();
            Console.WriteLine("End of Nokia demonstration.");
        }
    }
}