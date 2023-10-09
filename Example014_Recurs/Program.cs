string[,] table = new string[2, 5];
// table[0,0] table[0,1] table[0,2] table[0,4]
// table[1,0] table[1,1] table[1,2] table[1,4]
table[1,2] = "слово";
// for (int rows = 0; rows < table.GetLength(0); rows++)
// {
//     for (int columns = 0; columns < table.GetLength(1); columns++)
//     {
//         Console.Write(table[rows, columns] + " ");
//     }
//     Console.WriteLine();
// }

int [,] matrix = new int[3, 4];

void PrintArray(int[,] matr)
{
    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++)
        {
            Console.Write(matr[rows, columns] + " ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++)
        {
            matr[rows, columns] = new Random().Next(1, 10);
        }
        Console.WriteLine();
    }
}
//PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);