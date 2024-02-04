int n = int.Parse(Console.ReadLine());

int countP1 = 0, countP2 = 0, countP3 = 0, countP4 = 0, countP5 = 0;

for (int i = 0; i < n; i++)
{
    int number = int.Parse(Console.ReadLine());

    if (number < 200)
    {
        countP1++;
    }
    else if (number >= 200 && number <= 399)
    {
        countP2++;
    }
    else if (number >= 400 && number <= 599)
    {
        countP3++;
    }
    else if (number >= 600 && number <= 799)
    {
        countP4++;
    }
    else
    {
        countP5++;
    }
}

double percentP1 = countP1 / (double)n * 100;
double percentP2 = countP2 / (double)n * 100;
double percentP3 = countP3 / (double)n * 100;
double percentP4 = countP4 / (double)n * 100;
double percentP5 = countP5 / (double)n * 100;

Console.WriteLine($"{percentP1:f2}%");
Console.WriteLine($"{percentP2:f2}%");
Console.WriteLine($"{percentP3:f2}%");
Console.WriteLine($"{percentP4:f2}%");
Console.WriteLine($"{percentP5:f2}%");