int n = int.Parse(Console.ReadLine());
int sum = int.Parse(Console.ReadLine());
int maxNumber = sum;

for (int i = 1; i < n; i++)
{
    int currentNumber = int.Parse(Console.ReadLine());
    sum += currentNumber;

    if (currentNumber > maxNumber)
    {
        maxNumber = currentNumber;
    }
}

if (maxNumber == sum - maxNumber)
{
    Console.WriteLine("Yes");
    Console.WriteLine($"Sum = {maxNumber}");
}
else
{
    int diff = Math.Abs(maxNumber - (sum - maxNumber));
    Console.WriteLine("No");
    Console.WriteLine($"Diff = {diff}");
}