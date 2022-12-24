void FillArray(int[] collection)
{
    // длина массива length
    int length = collection.Length;
    int index = 0;
    while (index <  length)
    {
        collection[index] = new Random().Next(1, 10);
        // index = index + 1
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position <  count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int Index(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}
// создание массива из 10 чисел. Это по умолчанию нули.
int[] array = new int[10];

// заполняет рандомно массив
FillArray(array);
// Выводит массив на экран
PrintArray(array);
Console.WriteLine();

int pos = Index(array, 4);
Console.WriteLine(pos);

