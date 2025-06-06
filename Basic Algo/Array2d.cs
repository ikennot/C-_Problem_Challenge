using System;
class Array2d{


static void Main()
{

int[][] arr = new int[3][]; // 3 rows

arr[0] = new int[] { 1, 4, 7 };
arr[1] = new int[] { 2, 5, 8 };
arr[2] = new int[] { 3, 6, 9 };

  for(int i = 0; i < arr.Length;i++){
    
  for(int j = 0; j < arr[i].Length; j++)
     Console.Write(arr[i][j]+" ");

}
Console.WriteLine("");
}
}



/*

-Row move to 1
ia one greater than 0? - yes
-











*/