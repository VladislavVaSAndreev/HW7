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
void PrintArray(double[] array)
{
    System.Console.WriteLine("Среднее арифметическое каждого столбца: ");
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j] < 0)
        {
            System.Console.WriteLine($" {array[j]}\t");
        }
        else
        {
            System.Console.WriteLine($" {array[j]}\t");
        }
    }
    System.Console.WriteLine();
}

int[] sumColumns(int[,] myArray)
{
    int[,] array = myArray;
    int size = array.GetLength(1);
    int[] columnsSum = new int[size];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[j, i];
        }
        columnsSum[i] = sum;
    }
    return columnsSum;
}

double[] averageColumns(int[] array, int[,] args)
{
    double[] averageColumns = new double[array.Length];
    double y = (double)args.GetLength(0);
    for (int i = 0; i < array.Length; i++)
    {
        double x = (double)array[i];
        averageColumns[i] = Math.Round((x / y), 2);
    }
    return averageColumns;
}

int rows = ReadInt("введите число рядов: ");
int columns = ReadInt("введите число столбцов: ");
int[,] newArray = GenerateArray2D(rows, columns);
int[] myArgs = sumColumns(newArray);
PrintArray2D(newArray);
double[] averageValueColumns = averageColumns(myArgs, newArray);
PrintArray(averageValueColumns);
