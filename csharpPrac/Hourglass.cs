using System;

class Hourglass
{




static void Main()
{



Console.Write("Enter a number: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num<5|| num % 2 == 0)
{
Console.WriteLine("Invalid Input");
Environment.Exit(0);


}

int median = num/2+1;
int left = 1;
int right = num;
int i = 1;
bool isHalf = false;

Console.WriteLine("Value of Left: "+left);
Console.WriteLine("Value of Right: "+right);


Console.WriteLine("");



for( i = 1; i <=num; i++)
{

if(i >=median)
isHalf=true;
	

for(int j  = 1; j <= num; j++)
{

if(j>=left && j <= right)
Console.Write("*");
else 
Console.Write(" ");




}


if(!isHalf)
{
left++;
right--;
} else {
left--;
right++;
}

Console.WriteLine(" ");
}


Console.WriteLine(" ");

Console.WriteLine("Value of Left: "+left);
Console.WriteLine("Value of Right: "+right);













}


}