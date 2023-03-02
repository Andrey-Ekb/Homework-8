// Найти произведение двух матриц

void FillMatrix (int[,] matrix1, int [,]matrix2, int row, int col)
{
    Random rnd=new Random();
        for (int i=0; i<row; i++)
            for( int j=0; j<col; j++)
            { 
                matrix1[i,j] = rnd.Next(1,10);
                matrix2[i,j] = rnd.Next(1,10);   
            }     
}

void PrintMatrix (int[,]matrix1, int[,] matrix2, int n)
{
    for (int i=0; i<matrix1.GetLength(0); i++)
    { 
        for(int j=0; j<matrix1.GetLength(1); j++)
        {   
            if (n<2) 
            { 
                Console.Write($" {matrix1[i,j] }");
                n++;
            }
            else
            { 
                Console.WriteLine();
                Console.Write($" {matrix1[i,j] }");
                n=0;
            }
        }
    }

    Console.WriteLine();
    n=0;
    Console.WriteLine();

    for (int i=0; i<matrix2.GetLength(0); i++)
    { 
        for(int j=0; j<matrix2.GetLength(1); j++)
        {   
            if (n<2) 
            { 
                Console.Write($" {matrix2[i,j] }");
                n++;
            }
            else
            { 
                Console.WriteLine();
                Console.Write($" {matrix2[i,j] }");
                n=0;
            }
        }
    }
    Console.WriteLine();
}

void MatrixProduct (int[,] matrix1, int[,] matrix2, int [,]array)
{
array[0,0]=(matrix1[0,0]*matrix2[0,0])+matrix1[0,1]*matrix2[1,0];
array[0,1]=matrix1[0,0]*matrix2[0,1]+matrix1[0,1]*matrix2[1,1];
array[1,0]=matrix1[1,0]*matrix2[0,0]+matrix1[1,1]*matrix2[1,0];
array[1,1]=matrix1[1,0]*matrix2[0,1]+matrix1[1,1]*matrix2[1,1];

}
void PrintArray(int[,]array, int n)
{
    for(int i=0; i<array.GetLength(0); i++)
        for(int j=0; j<array.GetLength(1); j++)
             if (n<2) 
            { 
                Console.Write($" {array[i,j] }");
                n++;
            }
            else
            { 
                Console.WriteLine();
                Console.Write($" {array[i,j] }");
                n=0;
            }
}
Console.WriteLine();
int[,]matrix1=new int[2,2];
int[,]matrix2=new int[2,2];
int[,]array=new int[2,2];
int row=2;
int col=2;
int n=0;

Console.Clear();
FillMatrix(matrix1, matrix2, row, col);
PrintMatrix(matrix1, matrix2, n);
Console.WriteLine();
MatrixProduct(matrix1, matrix2, array);
PrintArray(array, n);