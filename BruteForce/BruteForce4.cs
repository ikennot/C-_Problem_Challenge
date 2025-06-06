using System;

class BruteForce4
{

static int[]minDiff(int[] arr)
{
int num1 = 0;
int num2= 0;
int diff = int.MaxValue;
for(int i = 0; i < arr.Length;i++)
{

for(int j = i+ 1; j < arr.Length;j++)
{
if(Math.Abs(arr[j]-arr[i]) < diff ){
diff = Math.Abs(arr[j] - arr[i]);

num2=arr[j];
num1=arr[i];
}
}


}

return new int[] {num1,num2};
}

static void Main()
{
int [] arr = {100, 300, 10, 40, 20};

int [] ans = minDiff(arr);

foreach(int i in ans)
Console.Write(i +" ");


}



}