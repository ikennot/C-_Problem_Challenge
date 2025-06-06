using System;
using System.Linq;


class SourceCode7{

public static void Median(int[] arr)
{
Array.Sort(arr);
int n = arr.Length-1;

Console.WriteLine("");

Console.WriteLine("Median: "+arr[(n/2)]);


}
public static void disp(int[] arr)
{
Console.WriteLine("");

for(int i = 0; i < arr.Length;i++){
Console.Write(arr[i]+"\t");
}

}

static void Main()
{

int num = 0;
int input = 0;
Console.Write("Input numbers Stored in an Array: ");
num = Convert.ToInt32(Console.ReadLine());
int [] arr = new int[num];
int i = 0;
while(i < num)
{
Console.Write("Input  number in index  "+(i+1)+" :");
input =Convert.ToInt32(Console.ReadLine());
arr[i]=input;
i++;
}

disp(arr);
Median(arr);
}

}