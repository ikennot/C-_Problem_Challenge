using System;

class StringPrac1
{


static void Main()
{


Console.Write("Enter a word: ");
String word = Console.ReadLine();


Console.WriteLine("Choose what do you want to do in a word");
Console.WriteLine("[1] Convert to UpperCase");
Console.WriteLine("[2] Count the number of words");
Console.WriteLine("[3] Replace a specific word");
Console.WriteLine("[4] Reverses the entire sentence");

int choose=Convert.ToInt32(Console.ReadLine());

switch(choose)
{

case 1:
String upper = word.ToUpper();

Console.WriteLine(upper);
break;


case 2:
int length = word.Length;

Console.WriteLine("Number of Words : "+length);
break;


case 3:
Console.Write("Enter a word do you want to replace :");
String rep= Console.ReadLine();

if(word.Contains(rep))
{
Console.Write("Enter a new Word : ");
String new1 = Console.ReadLine();

String revised = word.Replace(rep,new1);

Console.WriteLine("New Word :  "+ revised);

}else
{

Console.WriteLine("Word not found");
}

break;


case 4:

char[] tempStore = word.ToCharArray();
Array.Reverse(tempStore);
String reversed = new String(tempStore);

Console.WriteLine("Reversed Sentence : "+reversed);
break;



}




}


}