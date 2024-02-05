string bookName = Console.ReadLine();
string currentBook = Console.ReadLine();
int cnt = 0;

while (currentBook != "No More Books")
{
    if (currentBook == bookName) break;
    cnt++;
    currentBook = Console.ReadLine();
}

if (currentBook == "No More Books")
{
    Console.WriteLine("The book you search is not here!");
    Console.WriteLine($"You checked {cnt} books.");
}
else
{
    Console.WriteLine($"You checked {cnt} books and found it.");
}
