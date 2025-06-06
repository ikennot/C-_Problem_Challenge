using System;

class SourceCode5{

public static void Main(String[] args){
int fnum=0;
int snum=0;
int total = 0;
Console.Write("Enter first number: ");
fnum=Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number: ");
snum=Convert.ToInt32(Console.ReadLine());

for(int i = 1; i <= fnum;i++){
    total+=snum;
}
Console.WriteLine("product : {0}",total);
}
}