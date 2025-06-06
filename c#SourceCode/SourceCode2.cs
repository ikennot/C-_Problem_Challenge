using System;

class SourceCode2
{
public static void Main(String[] args){
int num= 0;
int sum = 0;
Console.Write("Enter Sum List of numbers:  ");
num = Convert.ToInt32(Console.ReadLine());
int [] arr1=new int[num];
for(int i = 0; i<arr1.Length;i++){
  arr1[i]=i+1;
  Console.WriteLine(arr1[i]);
  sum+=arr1[i];
}
Console.WriteLine("The sum is {0}",sum);
}
}