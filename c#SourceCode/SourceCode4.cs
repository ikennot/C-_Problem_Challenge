using System;

class SourceCode4{

public static void Main(String[] args){
String word="";
Console.Write("Input a sentence");
word=Console.ReadLine();
String[] wordList=word.Split(' ');
int numwords=0;
for(int i = 0; i < wordList.Length;i++){
numwords+=1;
}

Console.WriteLine("Number of words: "+numwords);
}

}