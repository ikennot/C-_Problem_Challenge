using System;

class Maskify
{

static void Main()
{
Console.Write("Enter a number: ");
String num = Console.ReadLine();
String mask="";

if(num.Length > 4){

for(int i   = 0; i < num.Length; i++)
{
if(i  < (num.Length)-4)
mask+='#';
else
mask+=num[i];
}

}else{

for(int i   = 0; i < num.Length; i++)
{
	mask+=num[i];
}


}


Console.WriteLine(mask);

}
}