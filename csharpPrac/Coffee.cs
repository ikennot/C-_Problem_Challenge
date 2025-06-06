using System;

class Coffee
{


static void Main()
{
Console.Write("Enter total of coffees: ");
int coffee=Convert.ToInt32(Console.ReadLine());
int total = 0;

for(int i  = 1; i <=coffee; i++)
{
if(i % 6 == 0){
 total+=2;
}else{
total+=1;
}
}


Console.WriteLine("Total: {0}",total);
}


}