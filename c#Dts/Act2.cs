using System;


class Act2
  {
public static void disp(int[,] arr1)
{
for(int i = 0; i < arr1.GetLength(0);i++){
   for(int j = 0; j < arr1.GetLength(1);j++){
          if(arr1[i,j] == 0)
           Console.Write("*\t");
            else
           Console.Write(arr1[i,j]+"\t");
      }
     Console.WriteLine("");
}

}
public static void Menu()
{
Console.WriteLine("Menu");
Console.WriteLine("[1] Create 2d Array");
Console.WriteLine("[2] Update Element");
Console.WriteLine("[3] Count the number of elements(s)");
Console.WriteLine("[4] Display row and column sum");
Console.WriteLine("[5] View Grid");
Console.WriteLine("[6] Exit");
Console.Write("Choose [1-6]: ");
}

static void Main(String[] args)
{
int choose = 0;
int[,] arr1= null;
int row = 0;
int col = 0;

while(choose != 6)
{
Menu();
choose= Convert.ToInt32(Console.ReadLine());
switch(choose)
{
case 1:
if(arr1 != null)
{
Console.WriteLine("2d Array Already Exists!");
}
Console.Write("Input 2D Array Column count : ");
col=Convert.ToInt32(Console.ReadLine());
if(col >= 11){
Console.WriteLine("Error! Invalid value for Column.");
break;
}
Console.Write("Input 2D Array Row count : ");
row= Convert.ToInt32(Console.ReadLine());
if(row > col){
Console.WriteLine("Error! Invalid value for row.");
break;
}

arr1=new int[row,col];
Console.WriteLine("2D Array created succesfully ");
break;

case 2:
if(arr1 == null){
Console.WriteLine("No valid 2D Array is Created");
break;
}
Console.Write("Input 2d Array column index : ");
int columnIndex=Convert.ToInt32(Console.ReadLine());
Console.Write("Input 2d Array row index : ");
int rowIndex=Convert.ToInt32(Console.ReadLine());
if(columnIndex>col || rowIndex> row){
Console.WriteLine("Error! Out of range index of  2D Array");
break;
}
Console.Write("Input value : ");
int value = Convert.ToInt32(Console.ReadLine());

if(arr1[rowIndex,columnIndex] == value){
Console.WriteLine("Cannot update using the same value!");
break;
}
arr1[rowIndex,columnIndex]=value;
Console.WriteLine("Updated successfully!");
break;

case 3:
if(arr1 == null){
Console.WriteLine("No valid 2D Array is Created");
break;
}
Console.Write("Input the Value to count : ");
int search= Convert.ToInt32(Console.ReadLine());
int count = 0;

for(int i = 0; i <arr1.GetLength(0);i++){
   for(int j = 0; j<arr1.GetLength(1);j++){
   if(search == arr1[i,j])
    count++;
}
}

Console.WriteLine("Count : "+count+" element(s) in the array");
break;

case 4:
if(arr1 == null){
Console.WriteLine("cannot perform, no valid 2D array exist!");
break;
}
for(int i = 0; i < arr1.GetLength(0);i++){
   int rowtotal= 0;
  for(int j = 0; j < arr1.GetLength(1);j++){
    Console.Write(arr1[i,j]+"\t");
     rowtotal+=arr1[i,j];
}
Console.Write("="+rowtotal);
Console.WriteLine("");
}

for(int i = 0; i < arr1.GetLength(0);i++){
   int coltotal= 0;
  for(int j = 0; j < arr1.GetLength(1);j++){
     coltotal+=arr1[j,i];
}
Console.Write("="+coltotal+"\t");

}
Console.WriteLine("");
break;

case 5:
disp(arr1);
break;

case 6:
break;

default:
Console.WriteLine("Invalid Input");
break;

}

}


}

}