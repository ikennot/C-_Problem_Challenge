using System;
class Hexa
{

static int convert(char i)
{
int num = 0;
switch(i)
{
case 'A':
num = 10;
break;
case 'B':
num = 11;
break;
case 'C':
num = 12;
break;
case 'D':
num = 13;
break;
case 'E':
 num = 14;
break;
case 'F':
 num = 15;
break;
default:
num = (int)Char.GetNumericValue(i);
break;
}
return num;
}

static void Main()
{
int equivalent = 0;
Console.Write("Enter a hexadecimal number : ");
String Hexadecimal=Console.ReadLine();

char[]HexaArr=Hexadecimal.ToCharArray();
int total = 0;
int index = 0;

for(int i  = HexaArr.Length-1; i >= 0; i--){
equivalent=convert(HexaArr[i]);
if(index == 0)
total += equivalent *1;
else
total += (equivalent*((int)Math.Pow(16,index)));

index++;

}
Console.WriteLine("Equivalent : {0}",total);

}





}