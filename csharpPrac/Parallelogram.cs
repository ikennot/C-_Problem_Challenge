using System;
class Parallelogram
{




static void Main()
{



Console.Write("Enter a number: ");
int num = Convert.ToInt32(Console.ReadLine());

int print=num*2-1;

int median =  print/2+1;

int left = median;
int right = print;


for(int i = 0; i < num; i++)
{

for(int j = 1; j <=print; j++)
{
if(j>=left&&j<=right)
Console.Write("* ");
else
Console.Write("_");

}

left--;
right--;
Console.WriteLine(" ");

}



}




















}