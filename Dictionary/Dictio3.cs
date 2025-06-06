using System;
using System.Collections.Generic;

class Dictio3
{

static void Main()
{
Dictionary <char,int> count = new Dictionary<char,int>();
Console.Write("Enter a word: ");
String input = Console.ReadLine();
char[] arr = input.ToCharArray();


foreach(char letter in arr)
{
if(letter ==' ')
continue;

if(count.ContainsKey(letter))
count[letter]++;
else
count[letter]=1;

}


foreach(KeyValuePair<char,int> i in count)
{
Console.WriteLine(i.Key+" : "+ i.Value);
}


}


}