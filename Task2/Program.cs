int ReadInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
void PrintArray2D(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            System.Console.Write($"{numbers[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}
int[,] GenerateArray2D(int rows, int columns)
{
    int[,] numbers = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = rnd.Next(-10, 10);
        }
    }
    return numbers;
}
bool Valideting(int rowsFind, int columnsFind, int[,] array)
{
    if (rowsFind > array.GetLength(0) - 1 || columnsFind > array.GetLength(1) - 1)
    {
        return false;
    }
    return true;
}

void PrintReadInt(int rowsFind, int columnsFind, int[,] array)
{
    if (Valideting(rowsFind, columnsFind, array))
    {
        System.Console.WriteLine($" В искомой ячейке, находится число: {array[rowsFind, columnsFind]}");
        return;
    }
    System.Console.WriteLine("такого числа нет в массиве");
}
int rows = ReadInt("введите число рядов: ");
int columns = ReadInt("введите число столбцов: ");
int[,] newArray = GenerateArray2D(rows, columns);
PrintArray2D(newArray);
int rowsFind = ReadInt("Введите строку поиска: ");
int columnsFind = ReadInt("Введите столбец поиска: ");
PrintReadInt(rowsFind, columnsFind, newArray);