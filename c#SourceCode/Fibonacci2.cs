using System;

class Fibonacci2
{

static void Main()
{
Console.Write("Enter number of Terms: ");
int numterms=Convert.ToInt32(Console.ReadLine());
int[] fibonacci = new int[numterms];

fibonacci[0]=0;
fibonacci[1]=1;

for(int i =2; i < numterms;i++){
   fibonacci[i]=fibonacci[i-2]+fibonacci[i-1];
}

foreach(int j in fibonacci)
   Console.Write(j);
}

}