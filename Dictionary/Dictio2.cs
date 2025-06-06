using System; 
using System.Collections.Generic;

class Dictio2
{

static String Sorting(String  i)
{
char[] convert = i.ToCharArray();
Array.Sort(convert);

return new String(convert);
}
static void Main()
{
  Dictionary<String,List<String>> Anagram = new Dictionary<String,List<String>>();
  string[] words = { "eat", "tea", "tan", "ate", "nat", "bat" };

   foreach(String i in words)
{
 String sorted = Sorting(i);
if(Anagram.ContainsKey(sorted))
   Anagram[sorted].Add(i);

else	
 Anagram[sorted] = new List<string> { i }; 

}


foreach(KeyValuePair<String,List<String>> entry in Anagram)
 Console.WriteLine(String.Join(", ", entry.Value));  // Join the list items with commas

}

}