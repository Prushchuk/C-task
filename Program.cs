
//int[] A = new int[5];
//double[,] B = new double[3, 4];

//Console.WriteLine("Enter mas 1: ");
//for (int i = 0; i < A.Length; i++)
//{
//    A[i] = Convert.ToInt32(Console.ReadLine());
//}

//Console.WriteLine("Mas A: ");
//foreach (var item in A)
//{
//    Console.WriteLine($"{item} ");
//}
//Console.WriteLine();

//Random rand = new Random();
//for (int i = 0; i < B.GetLength(0); i++)
//{
//    for (int j = 0; j < A.GetLength(1); j++)
//    {
//        B[i,j] = rand.NextDouble() * 10;
//        Console.WriteLine($"{B[i, j]}\t");
//    }
//    Console.WriteLine();
//}

//int max_A = A[0], min_A = A[0];
//for(int i = 0; i < A.Length; i++)
//{
//    if(max_A < A[i])
//    {
//        max_A = A[i];
//    }

//    if(min_A > A[i])
//    {
//        min_A = A[i];
//    }
//}
//Console.WriteLine($"Max number in array A: {max_A}");
//Console.WriteLine($"Min number in array A: {min_A}");

//int sum_A = 0, sumPar = 0, dob_A = 0;
//for (int i = 0; i < A.Length; i++)
//{
//    sum_A += A[i];
//    dob_A *= A[i];

//    if (A[i]%2==0)
//    {
//        sumPar += A[i];
//    }
//}
//Console.WriteLine($"Sum array A: {sum_A}");
//Console.WriteLine($"Sum par array A: {sumPar}");
//Console.WriteLine($"Dobytok array A: {dob_A}");

//double max_B = B[0,0],  min_B = B[0,0];

//for (int i = 0;i < B.Length;i++)
//{
//    for(int j = 0; j < B.Length; j++)
//    {
//        if(max_B < B[i,j])
//        {
//            max_B = B[i,j];
//        }
//        else if (min_B > B[i, j])
//        {
//            min_B = B[i,j];
//        }
//    }
//}
//Console.WriteLine($"Max num in array B: {max_B}");
//Console.WriteLine($"Min num in array B: {min_B}");

//double sum_B = 0, sumNePar_B = 0, dob_B = 1;
//for (int i = 0; i < B.Length; i++)
//{
//    for (int j = 0;j < B.Length; j++)
//    {
//        sum_B += B[i,j];
//        dob_B *= B[i,j];

//        if (B[i,j] % 2 != 0)
//        {
//            sumNePar_B += B[i, j];
//        }
//    }
//}
//Console.WriteLine($"Sum array B: {sum_B}");
//Console.WriteLine($"Dob array B: {dob_B}");
//Console.WriteLine($"Sum nePar B: {sumNePar_B}");

//using System.Linq.Expressions;

//int[,] array = new int[5, 5];
//Random rand = new Random();

//for (int i = 0; i < array.Length; i++)
//{
//    for (int j = 0; j < array.Length; j++)
//    {
//        array[i, j] = rand.Next(-100, 100);
//        Console.WriteLine($"{array[i, j]} \t");
//    }
//    Console.WriteLine();
//}

//int max = array[0, 0];
//int min = array[0, 0];

//for (int i = 0; i < array.Length; i++)
//{
//    for (int j = 0; j < array.Length; j++)
//    {
//        if (array[i, j] < min)
//        {
//            min = array[i, j];
//        }

//        else if (array[i, j] > max)
//        {
//            max = array[i, j];
//        }
//    }
//}

//int sum = 0;
//bool a = false;

//for (int i = 0; i < 5; i++)
//{
//    for(int j = 0;j < 5; j++)
//    {
//        if (array[i,j] == min || array[i,j] == max)
//        {
//            a = !a;
//        }

//        else if(a)
//        {
//            sum += array[i, j];
//        }
//    }
//}
//Console.WriteLine($"Min: {min}");
//Console.WriteLine($"Max: {max}");
//Console.WriteLine($"Sum: {sum}");
//using System;
//Console.OutputEncoding = System.Text.Encoding.UTF8;

//Console.WriteLine("Введіть рядок для шифрування: ");
//string text = Console.ReadLine();

//Console.WriteLine("Введіть число зсуву: ");
//int key = Convert.ToInt32(Console.ReadLine());

//string a = Encrypt(text, key);
//Console.WriteLine($"Зашифрований текст: {a}");

//string b = Decrypt(a, key);
//Console.WriteLine($"Розшифрований текст: {b}");
//string Encrypt(string text, int key)
//{
//    char[] res = text.ToCharArray();

//    for (int i = 0; i < res.Length; i++)
//    {
//        if (char.IsLetter(res[i]))
//        {
//            char offset = char.IsUpper(res[i]) ? 'A' : 'a';
//            res[i] = (char)((res[i] + key - offset) % 26 + offset);
//        }
//    }

//    return new string(res);
//}

//string Decrypt(string text, int key)
//{
//    return Encrypt(text, 26 - key);
//}

using System;
using System.Data;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("Введіть розмірність матриці: ");
Console.Write("Рядки: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Стовпці: ");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] matrixA = new int[rows, cols];
int[,] matrixB = new int[rows, cols];

Console.WriteLine("Матриця А: ");
Random(matrixA, rows, cols);

Console.WriteLine("Матриця В: ");
Random(matrixB, rows, cols);

Console.WriteLine("Введіть операцію 1 - множення число, 2 - додавання матриць, 3 - добуток матриць): ");
int operation = Convert.ToInt32(Console.ReadLine());

switch (operation)
{
    case 1:
        Console.WriteLine("Введіть число на яку помножити матрицю: ");
        int a = Convert.ToInt32(Console.ReadLine());
        MnojMatrix(matrixA, a);
        Console.WriteLine("Результат множення матриці А на число: ");
        Print(matrixA);
        break;

    case 2:
        AddMatrix(matrixA, matrixB);
        Console.WriteLine("Результат додавання матриць А і В: ");
        Print(matrixA);
        break;

    case 3:
        int[,] resMatrix = DobutMatrix(matrixA, matrixB);
        Console.WriteLine("Результат добутку матриць А і В: ");
        Print(resMatrix);
        break;

    default:
        Console.WriteLine("Невірна операція.");
        break;
}
void Random(int[,] matrix, int rows, int cols)
{
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = rand.Next(1, 11);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void MnojMatrix(int[,] matrix, int a)
{
    int rows = matrix.GetLength(0);
    int cols = matrix.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] *= a;
        }
    }
}

void AddMatrix(int[,] matrixA, int[,] matrixB)
{
    int rows = matrixA.GetLength(0);
    int cols = matrixA.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrixA[i, j] += matrixB[i, j];
        }
    }

}
int[,] DobutMatrix(int[,] matrixA, int[,] matrixB)
{
    int rowsA = matrixA.GetLength(0);
    int colsA = matrixA.GetLength(1);
    int colsB = matrixB.GetLength(1);

    int[,] resMatrix = new int[rowsA, colsA];

    for (int i = 0; i < rowsA; i++)
    {
        for (int j = 0; j < colsB; j++)
        {
            int sum = 0;
            for (int k = 0; k < colsA; k++)
            {
                sum += matrixA[i, k] * matrixB[k, j];
            }
            resMatrix[i, j] = sum;
        }
    }
    return resMatrix;
}

void Print(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int cols = matrix.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }

}
