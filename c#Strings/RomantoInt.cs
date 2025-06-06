using System;

class RomantoInt{

public static void Main(String[] args){
  String roman="III";
int numeric = 0;
int total=0;
int i  =0;
int [] wordKey=new int[roman.Length];
while(i < roman.Length){
char key=roman[i];
 switch(key){
      case 'I':
   numeric=1;
wordKey[i]=numeric;
      break;
      case 'V':
numeric=5;
wordKey[i]=numeric;
      break;
      case 'X':
numeric=10;
wordKey[i]=numeric;
      break;
      case 'L':
numeric=50;
wordKey[i]=numeric;
      break;
      case 'C':
numeric=100;
wordKey[i]=numeric;
      break;
      case 'D':
numeric=500;
wordKey[i]=numeric;
      break;
      case 'M':
numeric=1000;
wordKey[i]=numeric;
      break;
      default:
  numeric=0;
wordKey[i]=numeric;
      break;

}

i++;
}
for(int j = 0; j< wordKey.Length;j++){
Console.Write(wordKey[j]+" ");
}
for(int j = 0; j < wordKey.Length;j++){
  if(j == wordKey.Length-1){
     total+=wordKey[j];
     break;
    }
  if(wordKey[j]>=wordKey[j+1])
  total+=wordKey[j];
  else
  total-=wordKey[j];
}
Console.WriteLine("");
Console.WriteLine(total);
}

}