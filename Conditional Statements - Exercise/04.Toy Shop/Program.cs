double excurssion = double.Parse(Console.ReadLine());
int puzzles = int.Parse(Console.ReadLine());
int dolls = int.Parse(Console.ReadLine());
int bears = int.Parse(Console.ReadLine());
int minions = int.Parse(Console.ReadLine());
int trucks = int.Parse(Console.ReadLine());

double sum = puzzles * 2.6 + dolls * 3 + bears * 4.10 + minions * 8.20 + trucks * 2;
int totalToys = puzzles + dolls + bears + minions + trucks;


if (totalToys >= 50)
{
    sum -= sum * 0.25;
}

double rent = sum * 0.10;
double profit = sum - rent;

if (profit >= excurssion)
{
   double remainingMoney = profit - excurssion;
    Console.WriteLine($"Yes! {remainingMoney:F2} lv left.");
}
else
{
    double missingMoney = excurssion - profit;
    Console.WriteLine($"Not enough money! {missingMoney:F2} lv needed.");
}