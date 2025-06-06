using System;
class Bowtie
{




static void Main(){


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

bool isMedian = false;

for(int i = 1; i <=num;i++)
{

if(i>=median)
isMedian=true;

for(int j = 1; j <= num; j++)
{
if(j <= left || j >= right)
Console.Write("*");
else
Console.Write(" ");
}

if(!isMedian)
{
left++;
right--;
}else{
left--;
right++;

}
Console.WriteLine(" ");
}



}

















}