// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного масива.
/*
Console.WriteLine("Введите количество строк: ");
int linesVol = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int colomnsVol = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int [linesVol, colomnsVol];

FillArrayRandomNumbers(numbers);
Console.WriteLine();
Console.WriteLine("Массив до изменения");
PrintArray(numbers);

for (int i = 0; i < numbers.GetLength(0); i++)
{
    for ( int j = 0; j < numbers.GetLength(1) - 1; j++)
    {
        for (int z = 0; z < numbers.GetLength(1) - 1; z++)
        {
            if (numbers[i, z] < numbers [i, z + 1])
            {
                int temp = 0;
                temp = numbers[i, z];
                numbers[i, z] = numbers[i, z + 1];
                numbers[i, z + 1] = temp;
            }
        }
    }
}
Console.WriteLine();
Console.WriteLine("Массив с упорядоченными значениями");
PrintArray(numbers);

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j =0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "");
        }
        Console.WriteLine("");
    }
}
*/

// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
Console.Write("Введите размар прямоугольного массива: ");
int massivVol = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");
int[,] numbers = new int[massivVol, massivVol];

FillArrayRandomNumbers(numbers);
PrintArray(numbers);

int minsum = Int32.MaxValue;
int indexLine = 0;


for (int i = 0; i < numbers.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        sum = sum + numbers[i, j];
    }
    if (sum < minsum)
    {
        minsum = sum;
        indexLine++;
    }
}
Console.WriteLine("");
Console.WriteLine($"Cтрока с наименьшей суммой элементов под номером: {indexLine} с суммой элементов равной {minsum}");

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
*/

// Задайти две матрицы. Напишите программу, которая будет находить произведения двух матриц.

/*
int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

void FillArrayRandomNumber(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 5);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "");
        }
        Console.WriteLine("");
    }
}

int size = InputInt("Размерность матриц: ");
int[,] matrixA = new int[size, size];
int[,] matrixB = new int[size, size];
FillArrayRandomNumber (matrixA);
FillArrayRandomNumber (matrixB);
int[,] matrixC = new int[size, size];

for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        for (int z = 0; z < size; z++)
        {
            matrixC[i, j] = matrixC[i, j] + (matrixA[i, z] * matrixB[z, j]);
        }
    }
}


Console.WriteLine("Матрица - А");
PrintArray(matrixA);
Console.WriteLine("");
Console.WriteLine("Матрица - В");
PrintArray(matrixB);
Console.WriteLine("");
Console.WriteLine("Произведение матриц A*B");
PrintArray(matrixC);

*/

// Сформируйте трехмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добовляя индексы каждого элемента.

/*
int deep1 = InputInt("Введите размерность 1: ");
int deep2 = InputInt("Введите размерность 2: ");
int deep3 = InputInt("Введите размерность 3: ");
int countNumbers = 89;

if (deep1 * deep2 * deep3 > countNumbers)
{
    Console.WriteLine("Массив слишком большой");
    return;
}

int[,,] resultNumbers = Create3DMassive(deep1, deep2, deep3);

for (int i = 0; i < resultNumbers.GetLength(0); i++)
{
    for (int j = 0; j < resultNumbers.GetLength(1); j++)
    {
        for (int z = 0; z < resultNumbers.GetLength(2); z++)
        {
            Console.WriteLine($"[{i},{j},{z}] - {resultNumbers[i, j, z]}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,,] Create3DMassive(int size1, int size2, int size3)
{
    int[,,] array = new int[size1, size2, size3];
    int[] values = new int[countNumbers];
    int number = 10;

    for (int i = 0; i < values.Length; i++)
        values[i] = number++;

    for (int i = 0; i < values.Length; i++)
    {
        int randomInd = new Random().Next(0, values.Length);
        int temp = values[i];
        values[i] = values[randomInd];
        values[randomInd] = temp;
    }

    int valueIndex = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                array[i, j, z] = values[valueIndex++];
            }
        }
    }
    return array;
}

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

*/

// Заполните спирально массив 4 на 4.

Console.WriteLine("Введите разме масива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int [size, size];

int num = 1;
int i = 0;
int j = 0;

while (num <= size * size)
{
    numbers[i, j] = num;
    if (i <= j + 1 && i + j < size - 1)
        ++j;
    else if(i < j && i + j >= size - 1)
        ++i;
    else if (i >= j && i + j > size - 1)
        --j;
    else
        --i;
    ++num;
}

PrintArray(numbers);

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("");
    }
}