using System;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Bitte gib hier deinen Namen ein: ");
        string name = Console.ReadLine();
        
        Console.Write("Hallo {0}, gib bitte deine Geburtsjahr ein: ", name);
        int year = Convert.ToInt16(Console.ReadLine());

        Console.Write("Gib nun bitte deinen Geburtsmoant ein (MM): ");
        int month = Convert.ToInt16(Console.ReadLine());

        DateTime today = DateTime.Now;
        int currentYear = Convert.ToInt16(today.Year);
        int currentMonth = Convert.ToInt16(today.Month);

        int trueYear = currentYear - year;
        int trueMonth = currentMonth - month;

        if (trueMonth < 0)
        {
            trueYear--;
        }
        Console.Clear();
       
        Console.WriteLine("{0}, du bist {1} Jahre alt.", name ,trueYear);
      
        Thread.Sleep(30000);
    }
}
