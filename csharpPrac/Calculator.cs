using System;

class Calculator{

public static void Main(String[] args){
int fnum=0;
int snum= 0;

Console.Write("Enter first number: ");
fnum=Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number: ");
snum=Convert.ToInt32(Console.ReadLine());

int sum=fnum+snum;

Console.WriteLine("The sum is  "+sum);
}
}