using System;

class BasicAlgo1
{
static int getTotal(int num1, int num2)
{
if(num1==num2)
return (num1+num2)*3;
else
return num1+num2;
}
static void Main()
{
int sum = 0;
Console.Write("Enter first value: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second Value: ");
int num2 = Convert.ToInt32(Console.ReadLine());

sum=getTotal(num1,num2);

Console.WriteLine(sum);


}


}