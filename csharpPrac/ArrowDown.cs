using System;

class ArrowDown
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

int leftStraight = 3;
int rightStraight = num-2;
int left = 1;
int right = num;
int median = num/2+1;
bool isMedian = false;


for(int i = 1; i <= num; i++)
{

if(i >=median)
isMedian = true;


for(int j = 1; j <= num; j++)
{

if(!isMedian)
{
if(j >= leftStraight && j<=rightStraight)
Console.Write("* ");
else
Console.Write("_ ");

} else {

if(j >= left && j<=right)
Console.Write("* ");
else
Console.Write("_ ");

}

}


if(isMedian)
{
left++;
right--;
}

Console.WriteLine(" ");
}



}



}