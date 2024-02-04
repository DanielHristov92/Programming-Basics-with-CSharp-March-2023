int fee = int.Parse(Console.ReadLine());

double sneakers = fee - (fee * 0.4);
double tankTop =  sneakers - (sneakers * 0.2);
double ball = tankTop / 4;
double accessories = ball / 5;
double total = fee + sneakers + tankTop + ball + accessories;
Console.WriteLine(total);
