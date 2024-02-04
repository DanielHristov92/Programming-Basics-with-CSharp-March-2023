int pagesInBook = int.Parse(Console.ReadLine());
int PagesPerHour = int.Parse(Console.ReadLine());
int days = int.Parse(Console.ReadLine());

int timeForBook = pagesInBook / PagesPerHour;
int neededHours = timeForBook / days;
Console.WriteLine(neededHours);
