int age = int.Parse(Console.ReadLine());
double washingMachinePrice = double.Parse(Console.ReadLine());
int toyPrice = int.Parse(Console.ReadLine());

double money = 0;
int toysCount = 0;
int brotherMoney = 0;

for (int i = 1; i <= age; i++)
{
    if (i % 2 != 0)
    {
        toysCount++;
    }
    else
    {
        money += (10 * i) / 2;
        brotherMoney++;
    }
}

double totalMoney = money + (toysCount * toyPrice) - brotherMoney;

if (totalMoney >= washingMachinePrice)
{
    Console.WriteLine($"Yes! {totalMoney - washingMachinePrice:F2}");
}
else
{
    Console.WriteLine($"No! {washingMachinePrice - totalMoney:F2}");
}
    