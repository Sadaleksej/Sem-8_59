// See https://aka.ms/new-console-template for more information
using System;
using static System.Console;

Clear();
WriteLine();
int[,] arrr = new int[8, 6];
FilArray(arrr);
PrintArray(arrr);
Console.WriteLine("Введите значение:");
int num = Convert.ToInt32(ReadLine());
int[,] arrr2 = new int[arrr.GetLength(0) - 1, arrr.GetLength(1) - 1];
arrr2 = NewArray(arrr, num);
PrintArray(arrr2);

//FilArray(arrr);
//PrintArray(arrr);
//WriteLine();


void FilArray(int[,] ar)
{
    for (int i = 0; i < ar.GetLength(0); i++)
    {
        for (int j = 0; j < ar.GetLength(1); j++) ar[i, j] = new Random().Next(1, 99);
    }
}


void PrintArray(int[,] ar)
{
    for (int i = 0; i < ar.GetLength(0); i++)
    {
        for (int j = 0; j < ar.GetLength(1); j++) Write(ar[i, j] + " ");
        WriteLine();
    }
    WriteLine();
}

int[,] NewArray(int[,] ar, int number)
{
    int[,] res = new int[ar.GetLength(0) - 1, ar.GetLength(1) - 1];
    int k = ar.GetLength(0);
    int l = ar.GetLength(1);

    for (int i = 0; i < ar.GetLength(0); i++)
    {
        for (int j = 0; j < ar.GetLength(1); j++) if(ar[i, j] == number)
            {
                k = i;
                l = j;
            }
    }
    if (k == ar.GetLength(0))
    {
        WriteLine("нет такого элемента!");
        return res;         
    }

    int s1;
    int s2;
    for (int i = 0; i < ar.GetLength(0) - 1; i++)
    {
        for (int j = 0; j < ar.GetLength(1) - 1; j++)
        {
            if (i < k) s1 = i;
            else s1 = i + 1;
            if (j < l) s2 = j;
            else s2 = j + 1;
            res[i, j] = ar[s1, s2];
        }
    }
    return res;
}
