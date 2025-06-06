using System;
class Palindrome
{




static void Main(){

bool isPalindrome = true;
Console.Write("Enter a word: ");
String word	= Console.ReadLine();

if(word.Length % 2 == 0 || word.Length <=2){
Console.WriteLine("Please input odd numbers and at least 3 characters");
Environment.Exit(0);
}
int left = 0;
int right = word.Length-1;
int median = (word.Length-1)/2;
while(left<right)
{

if(word[left]!=word[right])
{
isPalindrome = false;
break;
}

right--;
left++;
}


if(isPalindrome){
Console.WriteLine("Word is Palindrome");
left = 0;
right = word.Length-1;

for(int i = 0; i < word.Length;i++)
{

for(int j = 0; j < word.Length;j++)
{

if(j==left|| j==right || j == median)
Console.Write(word[i]+" ");
else
Console.Write("_ ");

}
right--;
left++;
Console.WriteLine(" ");

}













//------------------------------------------------------------
}
else
Console.WriteLine("Word is Not Palindrome");

}








}