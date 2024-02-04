double budget = double.Parse(Console.ReadLine());
int videoCards = int.Parse(Console.ReadLine());
int processors = int.Parse(Console.ReadLine());
int ram = int.Parse(Console.ReadLine());

int videoCardsPrice = videoCards * 250;
double processorsPrice = videoCardsPrice * 0.35;
double ramPrice = videoCardsPrice * 0.10;
double processorsCount = processors * processorsPrice;
double ramCount = ram * ramPrice;
double totalSum = videoCardsPrice + processorsCount + ramCount;

if (videoCards > processors)
{
    totalSum -= totalSum * 0.15;
}

if (budget >= totalSum)
{
    double remainingMoney = budget - totalSum;
    Console.WriteLine($"You have {remainingMoney:F2} leva left!");
}
if (totalSum > budget)
{
    double neededMoney = totalSum - budget;
    Console.WriteLine($"Not enough money! You need {neededMoney:F2} leva more!");
}