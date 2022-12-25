string[,] table = new string[2,5];
// String.Empty
// table[0,0] table[0,1] table[0,2] table[0,4] 
// table[1,0] table[1,1] table[1,2] table[1,4] 

table[1,2] = "Слово";

for (int rows = 0; rows < 2; rows++)
{
    for (int colums = 0; colums < 5;colums++)
    {
        Console.WriteLine($"-{table[rows,colums]}-");
    }
}



void PrintArray (int[,] matr)
{
// for (int i = 0; i < 3; i++)
    for (int i = 0; i < matr.GetLength(0); i++)
    {
//    for (int j = 0; j < 4; j++)
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.WriteLine($"{matr[i, j]} ");
        }
    Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10);// [1,10)
        }
    }
}
int [,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);

// Как представить черно-белое изображение.

double Factorial(int n)
{
    // 1! = 1
    // 0! = 1
    if (n == 1) return 1;
    else return n * Factorial(n - 1);
}
for (int i = 0; i < 3; i++)
{
Console.WriteLine(Factorial(i)); // 1*2*3 = 6
}