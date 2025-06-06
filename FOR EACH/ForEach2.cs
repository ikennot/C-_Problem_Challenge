using System;


class ForEach2
{

static void Main()
{
int total = 0;
int []Integers={2,4,6,8,10};

foreach(int num in Integers)
total+=num;


Console.WriteLine(total);

}

}