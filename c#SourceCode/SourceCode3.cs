using System;

class SourceCode3
{
public static void Main(String[] args)
{
String word="";
Console.Write("Enter a word : ");
 word=Console.ReadLine();

char[] wordToArray=word.ToCharArray();

for(int i = wordToArray.Length-1;i >=0;i-- ){
  Console.Write(wordToArray[i]+" ");
}

}

}