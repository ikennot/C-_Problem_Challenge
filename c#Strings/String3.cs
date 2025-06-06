using System;


class String3{

public static void Main(String[] args){

String input="Java programming is fun";
String output="";
String []arrWords=input.Split(' ');

for(int i = 0 ; i < arrWords.Length;i++){
 String tempWords=arrWords[i];
if(tempWords.Length>0){
for(int j = tempWords.Length - 1; j >=0; j--){
if(tempWords.Length % 2 != 0)
output+=tempWords[j];
else{
output+=tempWords;
break;
}

}
output+=" ";
}
}
Console.WriteLine(output);


}

}