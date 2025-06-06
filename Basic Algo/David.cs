using System;

class David
{



 static void Main()
{

Console.Write("Enter a number");
int num = Convert.ToInt32(Console.ReadLine());
if(num % 2 == 0){
 Console.WriteLine("Even number");
Environment.Exit(0);
}


int left = num/2+1;
int right = num/2+1;
int upsideLeft = 1;
int upsideRight = num;
bool is1stLoop = true;
bool is2ndLoop = false;

for(int i = 1; i <=num-2; i++)
{

if(left <=3 && right >= (num-3))
is2ndLoop = true;

if(left < 1)
is1stLoop=false;


for(int j = 1; j <= num; j++)
{
      if((j>=	left && j <= right) && is1stLoop  || ((j >= upsideLeft && j <= upsideRight) && is2ndLoop) )
       Console.Write("*");
        else
       Console.Write("_");
}

left--;
right++;

if(is2ndLoop)
{
upsideLeft++;
upsideRight--;


}

Console.WriteLine();
}



}


}