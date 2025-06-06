using System;
class Diamond 
{


static void Main()
{

Console.Write("Enter a number: ");
int num = Convert.ToInt32(Console.ReadLine());
int print = num*2-1;
int median = print/2+1;

bool isHalf = false;
int medianLeft = median;
int medianRight=median;


int left = 1;
int right = print;


for(int i = 1; i <=print; i++){

if(i>=median)
isHalf = true;

for(int j = 1;j <=print;j++){
//
  if(!isHalf)
{
if(j >= medianLeft && j <= medianRight)
Console.Write("*");
else
Console.Write(" ");
} else {
  if(j >= left && j <=right)
   Console.Write("*");
else
Console.Write(" ");

}
//


}


if(isHalf){
left++;
right--;
}else{
medianLeft--;
medianRight++;
}

Console.WriteLine(" ");
}




}


}