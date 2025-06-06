using System;

class SourceCode1{


public static void Main(String[] args){
String word="";

Console.Write("Enter a word: ");
word=Console.ReadLine();
String[] arrWord=word.Split(' ');
int uppercase=0;
int lowercase=0;
foreach(String i in arrWord){
if (Char.IsUpper(i[0]))
			{
				uppercase = uppercase + 1;
			}
			else
			{
				lowercase = lowercase + 1;
			}

}


		Console.WriteLine("Uppercase words: "+uppercase);
		Console.WriteLine("Lowercase words: "+lowercase);

}



}