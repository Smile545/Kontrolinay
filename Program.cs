void PrintArray(string[] array, int a)
{
    for (int i = 0; i < a; i++)
    {
        Console.Write(array[i] + ' ');
    }
    Console.WriteLine();
}

Console.Write("Задайти длину массива ");
int a = Convert.ToInt32(Console.ReadLine());
string[] array = new string[a];
string[] newarray = new string[a];
for (int i = 0; i < a; i++)
{
    Console.WriteLine("Введите текст для массива");
    string c = Console.ReadLine();
    array[i] = c;
    if (array[i].Length <= 3)
    {
        newarray[i] = array[i];
    }
}