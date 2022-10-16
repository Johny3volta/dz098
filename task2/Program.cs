void PrintMassive(string[] massive)
{
    Console.Write("[" + string.Join(", ", massive) + "]");
    Console.WriteLine();
}

Console.Write("Введите кол-во строк будет в массиве: ");
int N = Convert.ToInt32(Console.ReadLine());
string[] firstMassive = new string[N];
for (int i = 0; i < firstMassive.Length; i++)
{
    Console.Write($"Введите значение в {i + 1}й строке массива: ");
    firstMassive[i] = Console.ReadLine();
}
int limitLength = 3;
string[] SelectionMassive(string[] massive)
{
    int count = 0;
    string[] newMassive = new string[massive.Length];
    foreach (string item in massive)
    {
        if (item.Length <= limitLength)
        {
            newMassive[count] = item;
            count++;
        }
    }
    Array.Resize(ref newMassive, count);
    return newMassive;
}

PrintMassive(firstMassive);
PrintMassive(SelectionMassive(firstMassive));