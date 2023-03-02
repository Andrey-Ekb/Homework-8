// Сформировать трехмерный массив не повторяющимися двузначными числами показать
// его построчно на экран выводя индексы соответствующего элемента



void FillArray (int [,,]array)
{ 
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i,j,k]= new Random().Next(100);
            }
        }
    }
}

void PrintArray (int [,,]array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
    Console.WriteLine("вывод листа № " + (i+1));
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i,j,k]}\t");
            }
            Console.WriteLine();
        }
    Console.WriteLine("________________");
    }
}
Console.WriteLine();

Console.WriteLine("Введите кол-во лиcтов: ");
int n=int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите длину строкт: ");
int m=int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите кол-во стлбцов: ");
int s=int.Parse(Console.ReadLine()!);

int[,,] array = new int[n,m,s];

FillArray(array);
PrintArray(array);