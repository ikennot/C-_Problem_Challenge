using System;


class BruteForce2
{

static int MaxProduct(int [] arr)
{

int max = 0;

for(int i = 0; i < arr.Length; i++)
{
for(int j = i+1; j < arr.Length; j++)
{
 if(i == j)
continue;

if(arr[i]*arr[j] > max)
max = arr[i] * arr[j];


}

}

return max;
}
static void Main()
{
int[] arr={-5, -10, 1, 3, -30};

int maximum=MaxProduct(arr);

Console.WriteLine(maximum);

}


}