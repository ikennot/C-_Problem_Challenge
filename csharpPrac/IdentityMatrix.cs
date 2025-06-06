using System;

class IdentityMatrix
{


static void Main()
{

Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int[num,num];

for(int i = 0; i < matrix.GetLength(0);i++)
{
    int n = matrix.GetLength(0) - 1;  // Last index of row/column
            matrix[i, i] = 1;                // Main diagonal
            matrix[ i, n - i] = 1;        // Reverse diagonal
for(int j = 0; j < matrix.GetLength(1);j++)
{
     Console.Write(matrix[i,j]+" ");

}
Console.WriteLine("");
}

}


}