
double strawberryLev = double.Parse(Console.ReadLine());
double bananaKg = double.Parse(Console.ReadLine());
double orange = double.Parse(Console.ReadLine());
double mallini = double.Parse(Console.ReadLine());
double strawberryKg = double.Parse(Console.ReadLine());

double mallinniPrice = strawberryLev * 0.50;
double orangePrice = mallinniPrice - (mallinniPrice * 0.40);
double bannanaPrice = mallinniPrice - (mallinniPrice * 0.80);
double malinnaSum = mallini * mallinniPrice;
double portokalsum = orange * orangePrice;
double bannnanasum = bananaKg * bannanaPrice;
double strawberysum = strawberryLev * strawberryKg;


double total = malinnaSum + portokalsum + bannnanasum + strawberysum;

Console.WriteLine($"Neede money: {total:F2}");