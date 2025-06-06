using System;

class ForEach3{



static void Main()
{
int [] Integers = {1, 2, 3, 4, 5, 6};
int even = 0;
int odd= 0;
foreach(int i in Integers)
{
    if(i%2==0)
    even++;
    else
    odd++;

}

Console.WriteLine("Even :"+even);
Console.WriteLine("Odd :"+ odd);
}

}