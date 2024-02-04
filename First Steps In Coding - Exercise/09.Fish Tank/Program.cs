int lenght = int.Parse(Console.ReadLine());
int width = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());
double percentage = double.Parse(Console.ReadLine());

int volume = lenght * width * height;
double volumeLitters = volume * 0.001;
double percentages = percentage / 100;
double total = volumeLitters * (1- percentages);
Console.WriteLine(total);