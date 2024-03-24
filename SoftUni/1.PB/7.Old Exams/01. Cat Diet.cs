int fat = int.Parse(Console.ReadLine());
int protein = int.Parse(Console.ReadLine());
int carbs = int.Parse(Console.ReadLine());
int calories = int.Parse(Console.ReadLine());
int water = int.Parse(Console.ReadLine());

double totalFat = ((fat / 100.0) * calories) / 9.0;
double totalProtein = ((protein / 100.0) * calories) / 4.0;
double totalCarbs = ((carbs / 100.0) * calories) / 4.0;

double totalFood = totalFat + totalProtein + totalCarbs;
double caloriesPerGram = calories / totalFood;

double totalCaloriesPerGram = caloriesPerGram * (1.0 - (water / 100.0));

Console.WriteLine($"{totalCaloriesPerGram:f4}");
