

using System.Xml.Schema;

double weight = double.Parse(Console.ReadLine());
        string serviceType = Console.ReadLine();
        double distance = double.Parse(Console.ReadLine());

        double pricePerKilometer = 0;
double totalprice = 0; 

if (serviceType == "standard")

{
    if (weight < 1)
        pricePerKilometer = 0.03;
    else if (weight <= 10)
        pricePerKilometer = 0.05;
    else if (weight <= 40)
        pricePerKilometer = 0.10;
    else if (weight <= 90)
        pricePerKilometer = 0.15;
    else
        pricePerKilometer = 0.20;

     totalprice = (double)distance * pricePerKilometer;
   
}
else if (serviceType == "express")
{

    if (weight < 1)
        pricePerKilometer = 0.03 * 0.80;

    else if (weight <= 10)
        pricePerKilometer = 0.05 * 0.40;
    else if (weight <= 40)
        pricePerKilometer = 0.10 * 0.05;
    else if (weight <= 90)
        pricePerKilometer = 0.15 * 0.02;
    else
        pricePerKilometer = 0.20 * 0.01;

    totalprice += (double)distance * pricePerKilometer; 
   
}
Console.WriteLine($"The delivery of your shipment with weight of {weight:F3} kg. would cost {totalprice:F2} lv.");
