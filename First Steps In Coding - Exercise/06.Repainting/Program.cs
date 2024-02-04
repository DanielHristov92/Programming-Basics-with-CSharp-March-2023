int nylon = int.Parse(Console.ReadLine());
int paint = int.Parse(Console.ReadLine());
int thinner = int.Parse(Console.ReadLine());
int hours = int.Parse(Console.ReadLine());

double nylonPrice = (nylon + 2) * 1.50;
double paintPrice = (paint * 1.1) * 14.50;
double thinnerPrice = thinner * 5.00;
double bags = 0.4;
double totalMaterials = nylonPrice + paintPrice + thinnerPrice + bags;
double craftsmen = 0.3 * totalMaterials;
double craftsManTotal = craftsmen * hours;
double totalCost = totalMaterials + craftsManTotal;


Console.WriteLine(totalCost);