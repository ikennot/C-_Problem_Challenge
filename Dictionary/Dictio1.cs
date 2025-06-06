using System;
using System.Collections.Generic;

class Dictio1
{


static void Main()
{
Dictionary<String,int> frequency  = new Dictionary <String,int>();
 String[] words = { "apple", "banana", "apple", "orange", "banana", "apple"};

/*x`
foreach(String i in words)
{
int count = 0;
for(int j = 0; j < words.Length; j++)
{
String countword=words[j];
if(i.Equals(countword,StringComparison.OrdinalIgnoreCase))
count++;

}
if(!frequency.ContainsKey(i))
frequency.Add(i,count);


}
*/

foreach (String word in words)
{
    if (frequency.ContainsKey(word))
    {
        frequency[word]++;
    }
    else
    {
        frequency[word] =1;
    }
}

foreach(KeyValuePair<String,int> entry in frequency)
Console.WriteLine(entry.Key+" : "+entry.Value);

}

}	