using System;

class Bruteforce5
{

static int MaxSum(int[]arr)
{
int sum = int.MinValue;

for(int i = 0; i < arr.Length; i++)
{
int totality = 0;
for(int j = i; j < arr.Length; j++){
 totality+=arr[j];

if(totality > sum)
sum=totality;

}

}

return sum; 
}
	
static void Main()
{
int []arr = {1, -2, 3, 4, -1, 2, 1, -5, 4};
int s= MaxSum(arr);

Console.WriteLine(s);
}


}