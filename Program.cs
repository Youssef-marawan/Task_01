Console.WriteLine("Welcome to Islam's Carpet Cleaning Service");
Console.WriteLine("Enter Number of small carpets:");
int small = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Number of large carpets:");
int large = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Price per small room: 25$");
Console.WriteLine("Price per large room: 35$");
int cost = (small * 25) + (large * 35);
double tax = cost * 0.06;
Console.WriteLine($"Cost : {cost} $");
Console.WriteLine($"Tax  : {tax} $");
Console.WriteLine("=========================");
double total = cost + tax;
Console.WriteLine($"Total estimate : {total} $");
Console.WriteLine("This estimate is valid for 30 days");

