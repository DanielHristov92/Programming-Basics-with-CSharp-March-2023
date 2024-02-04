double budget = double.Parse(Console.ReadLine());
int statists = int.Parse(Console.ReadLine());
double outfitPrice = double.Parse(Console.ReadLine());

double decor = budget * 0.10;
double outfit = statists * outfitPrice;

if (statists > 150)
{
    outfit -= outfit * 0.10;
}
double totalCost = decor + outfit;
if (totalCost > budget)
{
    double neededMoney = totalCost - budget;
    Console.WriteLine($"Not enough money!");
    Console.WriteLine($"Wingard needs {neededMoney:F2} leva more.");
}
else
{
    double remainingMoney = budget - totalCost;
    Console.WriteLine($"Action!");
    Console.WriteLine($"Wingard starts filming with {remainingMoney:F2} leva left.");
}