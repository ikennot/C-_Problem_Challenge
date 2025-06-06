using System;

class LongestWord
{

static void Main()
{
Console.Write("Enter a String: ");
String word=Console.ReadLine();

String [] sentence=word.Split(' ');
String longest="";

foreach(String i in sentence)
{
if(longest.Length<i.Length)
longest = i;

}

Console.WriteLine("The Longest word is: {0}",longest);
}



}