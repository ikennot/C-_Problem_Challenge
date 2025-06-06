using System;

class BruteForce3
{

static int missing(int[] arr)
{

for(int i = 0; i < arr.Length; i++){
if( i  == arr.Length-1)
break;

int next = arr[i]+1;
if(arr[i+1]!= next)
return next;

}

return 0;
}

static void Main()
{
int[] arr={-1,0,1,2,3,4,6,7,8};
int missingnum=missing(arr);

Console.WriteLine(missingnum);

}




}