string nameSeries = Console.ReadLine();
int durationEpisode = int.Parse(Console.ReadLine());
int durationBreak = int.Parse(Console.ReadLine());

double timeForLunch = durationBreak / 8.0;
double timeForBreak = durationBreak / 4.0;
double timeLeft = durationBreak - timeForLunch - timeForBreak;

if (timeLeft >= durationEpisode)
{
    double left = timeLeft - durationEpisode;
    Console.WriteLine($"You have enough time to watch {nameSeries} and left with {Math.Ceiling(left)} minutes free time.");
}
else
{
    double neededTime = durationEpisode - timeLeft;
    Console.WriteLine($"You don't have enough time to watch {nameSeries}, you need {Math.Ceiling(neededTime)} more minutes.");
}