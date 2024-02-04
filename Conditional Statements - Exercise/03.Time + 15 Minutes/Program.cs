int hour = int.Parse(Console.ReadLine());
int minutes = int.Parse(Console.ReadLine());

int nextHour = (hour + (minutes + 15) / 60) % 24;
int nextMinutes = (minutes + 15) % 60;

Console.WriteLine($"{nextHour}:{nextMinutes:D2}");