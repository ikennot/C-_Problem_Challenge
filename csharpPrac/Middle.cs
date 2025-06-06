using System;


class Middle{

static void Main()
{
Console.Write("Enter a String: ");
String word = Console.ReadLine();

String middle ="";
int n = (word.Length-1)/2;
if((word.Length)%2==0)
    middle = word[n].ToString() + word[n+1].ToString();
else
middle =  word[n].ToString();


Console.WriteLine(middle);



}

}

