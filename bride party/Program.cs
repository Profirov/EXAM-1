
double partyPrice = double.Parse(Console.ReadLine());
int lMess = int.Parse(Console.ReadLine());
int roza = int.Parse(Console.ReadLine());
int key  = int.Parse(Console.ReadLine());
int pic  = int.Parse(Console.ReadLine());
int lucky  = int.Parse(Console.ReadLine());

double totalPrice = lMess * 0.60 + roza * 7.20 + key * 3.60 + pic * 18.20 + lucky * 22.00;
double artCount = lMess + roza  + key + lucky;

if (artCount >= 25)
{
    totalPrice *= 0.65;
    
}
totalPrice *= 0.90;

double remainingmoney = partyPrice - totalPrice;
if (totalPrice >= partyPrice)
{
    Console.WriteLine($"Yes! {Math.Abs(remainingmoney):F2} lv left");
}
else
{
    double needone = totalPrice - partyPrice;
    Console.WriteLine($"Not enough money! {Math.Abs(needone):F2} lv needed");
}