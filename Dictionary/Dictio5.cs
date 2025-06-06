/* Alright! Here's another interesting problem that involves using a Dictionary in C#.

Problem: Find the Most Frequent Word
Description: Given a list of words, find the word that appears the most frequently. If there are multiple words with the same highest frequency, return any one of them.

Input:

An array of strings, e.g., string[] words = { "apple", "banana", "apple", "orange", "banana", "apple", "grape", "banana", "banana" };
Output: The word with the highest frequency and its count.


Input: { "apple", "banana", "apple", "orange", "banana", "apple", "grape", "banana", "banana" }
Output: banana : 4


*/



using System;
using System.Collections.Generic;

class Dictio5
{

static void Main()
{
Dictionary<String,int> frequency = new Dictionary <String,int>();
int highest = int.MinValue;
String[] input = { "apple", "banana", "apple", "orange", "banana", "apple", "grape", "banana", "banana" };

foreach( String word in input)
{

if(frequency.ContainsKey(word))
frequency[word]++;
else
frequency[word]=1;
}

foreach(KeyValuePair<String,int> i in frequency){
if(i.Value>highest)
highest = i.Value;

}


foreach(KeyValuePair<String,int> i in frequency)
{
if(i.Value == highest)
Console.WriteLine(i.Key+": "+i.Value);
}
}



}