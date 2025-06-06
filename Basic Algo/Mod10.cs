using System;

class Mod10{


static void Main()
{

int num = 123;
int new1 = 0;
int cop = 123;
Console.WriteLine(cop);
int rem =0;
while (cop > 0)
{

rem = cop % 10;
Console.WriteLine(rem);
new1 *=10 + rem;

cop /=10;

}

Console.WriteLine(new1);
}

}