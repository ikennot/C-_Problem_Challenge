using System;
using System.Collections.Generic;

class Dictio4
{

static void Main()
{
Dictionary <String,int> consonantvowel = new Dictionary<String,int>();
consonantvowel.Add("Consonant",0);
consonantvowel.Add("Vowel",0);
Console.Write("Input a word: ");
String input = Console.ReadLine();
char[] arr=input.ToCharArray();
String vow ="aeiouAEIOU";

foreach(char i in arr)
{
if(i == ' ')
continue;

bool isvowel=false;
for(int j = 0;j < vow.Length;j++)
{
      if( i == vow[j])
       {
         isvowel=true;
          break;
       }
      
}

if(isvowel)
 consonantvowel["Vowel"]++;
else
consonantvowel["Consonant"]++;

}

foreach(KeyValuePair<String,int> entry in consonantvowel)
  Console.WriteLine(entry.Key+" : "+entry.Value);
}

}