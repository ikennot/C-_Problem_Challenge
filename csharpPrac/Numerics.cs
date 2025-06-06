using System;

class Numerics
{



static void Main()
{
Console.Write("Enter of String of Numbers: ");
String nums=Console.ReadLine();
String [] numArr = nums.Split('.','-');
bool isNumeric = true;
int num;
foreach(String i in numArr){
 
isNumeric=int.TryParse( i, out num);

if(!isNumeric)
break;


}

Console.WriteLine(isNumeric);


}





}