using System;

class Maxmin
{

static void Main()
{
int []arr = {10, 15, 20, 2, 10, 6};

Array.Sort(arr);
int diff = arr[arr.Length-1]-arr[0];
Console.WriteLine(diff);
}

}