using System;

class Prime
{

static bool isPrime(int num)
{
    if (num <= 1) return false;
        if (num == 2) return true;
for(int i = 2;  i <  Math.Sqrt(num); i++ ){

if(i == num)
continue;

if(num % i == 0)
return false;


}

return true;
}

static void Checker(int num)
{
int leftcount = num -1;
int rightcount= num +1;
while(!isPrime(leftcount))
{
leftcount--;
}

while(!isPrime(rightcount))
{
rightcount++;
}

int quotient=(leftcount+rightcount)/2;
if(quotient == num)
Console.WriteLine("Balanced Prime");
else if(quotient < num)
Console.WriteLine("Strong Prime");
else if(quotient > num)
Console.WriteLine("weak Prime");


}


static void Main()
{
int num = 0;
Console.Write("Enter a number :");
num=Convert.ToInt32(Console.ReadLine());
if(isPrime(num)){
Console.WriteLine("Number is Prime");
Checker(num);
}
else
Console.WriteLine("Number is not Prime");



}



}
