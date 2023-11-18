using System;

class Program
{
    static void Main()
    {
        int seaPackages = int.Parse(Console.ReadLine());
        int mountainPackages = int.Parse(Console.ReadLine());

        string command = Console.ReadLine();
        int totalProfit = 0;

        while (command != "Stop")
        {
            if (command == "sea" && seaPackages > 0)
            {
                totalProfit += 680;
                seaPackages--;
            }
            else if (command == "mountain" && mountainPackages > 0)
            {
                totalProfit += 499;
                mountainPackages--;
            }

            command = Console.ReadLine();
            
        }

        if (seaPackages == 0 && mountainPackages == 0)
        {
            Console.WriteLine("Good job! Everything is sold.");
        }
        else
        {
            Console.WriteLine($"Profit: {totalProfit} leva.");
        }
        
    }
}
