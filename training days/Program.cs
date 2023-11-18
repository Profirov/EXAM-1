

using System;

class Program
{
    static void Main()
    {
        int days = int.Parse(Console.ReadLine());
        double initialKilometers = double.Parse(Console.ReadLine());
        double totalKilometers = initialKilometers;

        for (int i = 1; i <= days; i++)
        {
            int percentIncrease = int.Parse(Console.ReadLine());
            double additionalKilometers = (percentIncrease / 100.0) * initialKilometers;
            initialKilometers += additionalKilometers;
            totalKilometers += initialKilometers;
        }

        double difference = Math.Abs(totalKilometers - 1000);

        if (totalKilometers >= 1000)
        {
            Console.WriteLine($"You've done a great job running {totalKilometers:F0} kilometers more than the goal!");
        }
        else
        {
            Console.WriteLine($"Sorry Mrs. Ivanova, you need to run {difference:F0} more kilometers to reach your goal of 1000 kilometers.");
        }
    }
}
