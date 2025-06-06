using System;

class Calculator2{

public static void Main(String[] args){
int fnum =0;
int snum = 0;
int choose = 0;
int answer = 0;

Console.Write("Enter first number : ");
fnum=Convert.ToInt32(Console.ReadLine());

Console.Write("Enter second number : ");
snum=Convert.ToInt32(Console.ReadLine());

Console.Write("choose a number 1 - 4 : ");
choose=Convert.ToInt32(Console.ReadLine());

if(choose == 1){
 answer=fnum+snum;
}else if(choose == 2){
answer=fnum-snum;

}else if(choose == 3){
 answer=fnum*snum;
}else if(choose == 4){
 answer=fnum/snum;
}else{
Console.WriteLine("Invalid number");
}

Console.WriteLine("answer = "+answer);
}

}