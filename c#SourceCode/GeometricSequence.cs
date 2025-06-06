using System;

class GeometricSequence
{

static void Main()
{
int numTerms = 0;
int numRatio = 0;
int numStart = 0;

Console.Write("Enter number of terms : ");
 numTerms=Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the common Ratio :  ");
numRatio= Convert.ToInt32(Console.ReadLine());

Console.Write("Enter starting number: ");
numStart=Convert.ToInt32(Console.ReadLine());

for(int i = 1; i <= numTerms; i++){
       Console.Write("{0},",numStart);
       numStart*=numRatio;
}

}





}