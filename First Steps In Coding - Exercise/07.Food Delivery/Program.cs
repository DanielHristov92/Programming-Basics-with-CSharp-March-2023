int chickenMenu = int.Parse(Console.ReadLine());
int fishMenu = int.Parse(Console.ReadLine());
int veggieMenu = int.Parse(Console.ReadLine());

double chickenPrice = chickenMenu * 10.35;
double fishPrice = fishMenu * 12.40;
double veggiePrice = veggieMenu * 8.15;
double delivery = 2.5;
double totalCost = chickenPrice + fishPrice + veggiePrice;
double dessert = totalCost * 0.2;
double total = totalCost + dessert + delivery;
Console.WriteLine(total);
