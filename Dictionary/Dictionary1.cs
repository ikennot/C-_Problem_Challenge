using System;
using System.Collections.Generic;


class Dictionary1
{



static void Main(){


Dictionary <string,int> freq = new Dictionary <string,int>();
String word = "the cat and the dog played with the other cat";

String[] fil=word.Split(' ');


foreach(String i in fil){

if(freq.ContainsKey(i))
freq[i]++;
else
freq[i]=1;
}



foreach(KeyValuePair<string,int> i in freq)
{
Console.WriteLine(i.Key +" : "+i.Value);
}


}

}