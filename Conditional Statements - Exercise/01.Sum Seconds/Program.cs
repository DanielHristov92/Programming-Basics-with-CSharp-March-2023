int firstTime = int.Parse(Console.ReadLine());
int sedondTime = int.Parse(Console.ReadLine());
int thirdTime = int.Parse(Console.ReadLine());

int totalTime = firstTime + sedondTime + thirdTime;

int minutes = totalTime / 60;
int  seconds = totalTime % 60;

Console.WriteLine($"{minutes}:{seconds:D2}");