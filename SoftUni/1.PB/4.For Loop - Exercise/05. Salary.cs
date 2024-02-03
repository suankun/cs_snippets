int tabs = int.Parse(Console.ReadLine());
int salary = int.Parse(Console.ReadLine());

bool flag = true;

for (int i = 0; i < tabs; i++)
{
    string website = Console.ReadLine();
    if (website == "Facebook") salary -= 150;
    else if (website == "Instagram") salary -= 100;
    else if (website == "Reddit") salary -= 50;

    if (salary <= 0)
    {
        flag = false;
        break;
    }
}

if (flag) Console.WriteLine(salary);
else Console.WriteLine("You have lost your salary.");
