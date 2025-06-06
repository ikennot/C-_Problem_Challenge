using System;

class Act1
{

public static void Menu()
{
Console.WriteLine("Menu");
Console.WriteLine("[1] Input number of Elements");
Console.WriteLine("[2] Update element");
Console.WriteLine("[3] Search Element");
Console.WriteLine("[4] Copy Array Element");
Console.WriteLine("[5] Sort Element");
Console.WriteLine("[6] Display element");
Console.WriteLine("[7] Exit");
Console.Write("Choose [1-7]: ");
}

public static void disp(int[] arr)
{

for(int i = 0; i < arr.Length; i++)
Console.Write(arr[i]+ " ");

Console.WriteLine("");
}
public static void Main(String[] args)
{
int choose= 0;
int[]arr1=null;
int[] arr2=null;
int elements= 0;
int index=0;
int search= 0;
int elementNumbers = 0;
while(choose != 7)
{
Menu();
choose=Convert.ToInt32(Console.ReadLine());
switch(choose){
case 1:
if(arr1!=null){
Console.WriteLine("Array has already elements");
}
Console.Write("Input the number elements of an array: ");
elementNumbers=Convert.ToInt32(Console.ReadLine());
arr1=new int[elementNumbers];
Console.WriteLine("Succesfully added");
break;
case 2:
if(arr1 == null){
Console.WriteLine("Array Elements doesnt initialized!");
break;
}
Console.Write("Enter index number: ");
index=Convert.ToInt32(Console.ReadLine());
if(index>=arr1.Length){
Console.WriteLine("Index out of bounds!!");
break;
}
Console.Write("Input element : ");
elements=Convert.ToInt32(Console.ReadLine());
arr1[index]=elements;

Console.WriteLine("Element "+elements+" succesfully added at Index "+index);
break;
case 3:
if(arr1 == null){
Console.WriteLine("Array Elements doesnt initialized!");
break;
}
bool found = false;
Console.Write("Input element to search : ");
search=Convert.ToInt32(Console.ReadLine());
for(int i = 0; i < arr1.Length;i++){
if(arr1[i] == search){
found = true;
break;
}

}

if(found)
Console.WriteLine("Element "+search+" found!");
else
Console.WriteLine("Element not found");
break;
case 4:
if(arr1 == null){
Console.WriteLine("Array Elements doesnt initialized!");
break;
}
if(arr2 != null){
Console.WriteLine("Array already copied!");
break;
}
arr2=new int[elementNumbers];
Array.Copy(arr1,arr2,elementNumbers);
disp(arr2);
break;
case 5:
if(arr1 == null){
Console.WriteLine("Array Elements doesnt initialized!");
break;
}
Array.Sort(arr1);
Console.WriteLine("Array sorted!");
break;

case 6:
if(arr1 == null){
Console.WriteLine("Array Elements doesnt initialized!");
break;
}
disp(arr1);
break;

case 7:
break;

default:
break;

}


}

}
}