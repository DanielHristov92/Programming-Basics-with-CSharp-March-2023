string actorName = Console.ReadLine();
double academyPoints = double.Parse(Console.ReadLine());
int judgesCount = int.Parse(Console.ReadLine());

for (int i = 0; i < judgesCount; i++)
{
    string judgeName = Console.ReadLine();
    double judgePoints = double.Parse(Console.ReadLine());

    double currentPoints = (judgeName.Length * judgePoints) / 2.0;
    academyPoints += currentPoints;

    if (academyPoints > 1250.5)
    {
        Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {academyPoints:f1}!");
        return;
    }
}

double neededPoints = 1250.5 - academyPoints;
Console.WriteLine($"Sorry, {actorName} you need {neededPoints:f1} more!");