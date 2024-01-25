string product = Console.ReadLine();

string type;

if (product == "banana" || product == "apple" || product == "kiwi" || product == "cherry" || product == "lemon" || product == "grapes") type = "fruit";
else if (product == "tomato" || product == "cucumber" || product == "pepper" || product == "carrot") type = "vegetable";
else type = "unknown";

Console.WriteLine(type);
