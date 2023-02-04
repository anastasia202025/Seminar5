/* Задача 3: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
3 7 22 2 78 -> 76*/

Console.Clear();

int InputInt(string message)
{
    System.Console.Write(message + ">");
    string? inputValue = Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}

void CreateArray(double[] array)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(100, 1000) + random.NextDouble;
    }
}
void PrintArray(double[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i]);
        if (i != array.Length - 1)
        {
            System.Console.Write(",");
        }
    }
    System.Console.Write("]");
    System.Console.WriteLine();
}
void Calculations(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j] > max)
        {
            max = array[j];
        }
        if (array[j] < min)
        {
            min = array[j];
        }
    }

    System.Console.WriteLine($"Максимальное значение элемента в массиве = {max}.");
    System.Console.WriteLine($"Минимально значение элемента в массиве = {min}.");
    System.Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");
}
int size = InputInt("Введите количество элементов массива");
double[] array = new double[size];
CreateArray(array);
System.Console.WriteLine("Наш массив: ");
