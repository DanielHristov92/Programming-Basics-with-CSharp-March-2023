int packageOfPens = int.Parse(Console.ReadLine());
int packageOfMarkers = int.Parse(Console.ReadLine());
int litresOfCleaner = int.Parse(Console.ReadLine());
int discount =  int.Parse(Console.ReadLine());

double priceOfPens = packageOfPens * 5.80;
double priceOfMarkers = packageOfMarkers * 7.20;
double priceOfCleaner = litresOfCleaner * 1.20;
double totalCost = priceOfPens + priceOfMarkers + priceOfCleaner;
double totalWithDiscount = totalCost - (totalCost * discount / 100);
Console.WriteLine(totalWithDiscount);