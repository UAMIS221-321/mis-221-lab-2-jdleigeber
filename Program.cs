double costOfSandwich = 4.75;
double costOfToppings = 0.55;
double discountRate = 0.10;

Console.WriteLine("Enter the number of sandwiches");

int numberOfSandwiches = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the number of toppings");

int numberOfToppings = int.Parse(Console.ReadLine());

Console.WriteLine("Enter a tip amount");

double tipAmount = double.Parse(Console.ReadLine());

double totalSandwichCost = costOfSandwich * numberOfSandwiches;

double totalToppingCost = costOfToppings * numberOfToppings;

double baseCost = totalSandwichCost + totalToppingCost;

double orderCost = tipAmount + baseCost * (1-discountRate);

orderCost = Math.Round(orderCost,2);

Console.WriteLine("Your order cost is " + "$" + orderCost);

