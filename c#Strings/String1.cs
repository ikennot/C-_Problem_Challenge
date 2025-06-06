using System;

class String1{




public static void Main(String[] args){
String input = "Hello world from c#";
String output="";

int n=input.Length;
for(int i  =  n-1 ; i >= 0; i--){

output+=input[i];

}

Console.WriteLine(output);
}
}