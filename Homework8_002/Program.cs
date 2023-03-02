// В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.

int ReadInt()
{
    Console.Write("Введите размер массива : ");
    return int.Parse(Console.ReadLine()!);
}

void FillArray (int[,] array)
{
    Random rnd=new Random();
        for (int i=0; i<array.GetLength(0); i++)
            for(int j=0; j<array.GetLength(1); j++)
                array[i,j] = rnd.Next(1,50);
}

void PrintArray (int[,]array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {   
        for(int j=0; j<array.GetLength(1); j++)
            Console.Write($" {array[i,j]} \t");
        Console.WriteLine();
    }   
    Console.WriteLine();
}

void FindMin (int [,]array, int row, int col)
{
int min=array[0,0];
    for(int i=0; i<array.GetLength(0); i++)
    { 
        for(int j=0; j<array.GetLength(1); j++)
        {
            if(min>array[i,j])
            { 
                min=array[i,j];
                row=i;
                col=j;
            }
        }
    }
Console.WriteLine("наименьший элемент строка/колонка "+(row+1)+"/"+(col+1));
Console.WriteLine();
int[,]matrix=new int[array.GetLength(0)-1,array.GetLength(1)];

    for(int i=0; i<matrix.GetLength(0);i++)
    {
        for(int j=0; j<matrix.GetLength(1); j++)
        { 
            if(i==row) matrix[i,j]=array[(i+1),j];
            else matrix[i,j]=array[i,j];
        }
    }

int[,]result=new int[matrix.GetLength(0),matrix.GetLength(1)-1];

    for(int i=0; i<result.GetLength(0);i++)
    {
        for(int j=0; j<result.GetLength(1); j++)
        { 
            if(col==j)
            {
                result[i, j]=matrix[i, j];
            }
            else result[i, j]=matrix[i, j+1];    
        }
    }
    Console.WriteLine();

    for (int i=0; i<result.GetLength(0); i++)
    {   
        for(int j=0; j<result.GetLength(1); j++)
            Console.Write($" {result[i,j]} \t");
        Console.WriteLine();
    }   
    Console.WriteLine();
}

Console.Clear();
Console.WriteLine();
int m=ReadInt();
int n=ReadInt();
Console.WriteLine();

int[,]array=new int[m,n];
int row=0;
int col=0;

FillArray(array);
PrintArray(array);
Console.WriteLine();
FindMin(array, row, col);
