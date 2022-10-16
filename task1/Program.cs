void PrintMassive(string[] massive)
{
    Console.Write("[" + string.Join(", ", massive) + "]");
    Console.WriteLine();
}

string[] firstMassive = { "Hello", "2", "world", ":-)" };
int limitLength = 3;
int count = 0;
for (int i = 0; i < firstMassive.Length; i++)
{
    if (firstMassive[i].Length <= limitLength)
        count++;
}
string[] endMassive = new string[count];
int j = 0;
int k = 0;
while (j < endMassive.Length)
{
    if (firstMassive[k].Length <= limitLength)
    {
        endMassive[j] = firstMassive[k];
        j++;
    }
    k++;
}

PrintMassive(firstMassive);
PrintMassive(endMassive);
