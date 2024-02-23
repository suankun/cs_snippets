string begin = Console.ReadLine();
string end = Console.ReadLine();

for (int i = begin[0] - '0'; i <= end[0] - '0'; i++)
    for (int j = begin[1] - '0'; j <= end[1] - '0'; j++)
        for (int k = begin[2] - '0'; k <= end[2] - '0'; k++)
            for (int l = begin[3] - '0'; l <= end[3] - '0'; l++)
                if (i%2!=0 && j%2!=0 && k%2!=0 && l%2!=0) Console.Write($"{i}{j}{k}{l} ");
