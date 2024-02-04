int groupCount = int.Parse(Console.ReadLine());

double mussala = 0;
double monblanc = 0;
double kilimanjaro = 0;
double k2 = 0;
double everest = 0;

for (int i = 0; i < groupCount; i++)
{
    int groupSize = int.Parse(Console.ReadLine());

    if (groupSize <= 5)
    {
        mussala += groupSize;
    }
    else if (groupSize <= 12)
    {
        monblanc += groupSize;
    }
    else if (groupSize <= 25)
    {
        kilimanjaro += groupSize;
    }
    else if (groupSize <= 40)
    {
        k2 += groupSize;
    }
    else
    {
        everest += groupSize;
    }
}
double total = mussala + monblanc + kilimanjaro + k2 + everest;
Console.WriteLine($"{(mussala * 100.0 / total):f2}%");
Console.WriteLine($"{(monblanc * 100.0 / total):f2}%");
Console.WriteLine($"{(kilimanjaro * 100.0 / total):f2}%");
Console.WriteLine($"{(k2 * 100.0 / total):f2}%");
Console.WriteLine($"{(everest * 100.0 / total):f2}%");