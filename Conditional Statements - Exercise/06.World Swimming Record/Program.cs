double recordInSeconds = double.Parse(Console.ReadLine());
double meters = double.Parse(Console.ReadLine());
double secondsFor1m = double.Parse(Console.ReadLine());

double mustSwim = meters * secondsFor1m;
double delay = Math.Floor(meters / 15) * 12.5;
double totalTime = mustSwim + delay;

if (totalTime < recordInSeconds)
{
    Console.WriteLine($" Yes, he succeeded! The new world record is {totalTime:F2} seconds.");
}
else
{
    double neededTime = totalTime - recordInSeconds;
    Console.WriteLine($"No, he failed! He was {neededTime:F2} seconds slower.");
}