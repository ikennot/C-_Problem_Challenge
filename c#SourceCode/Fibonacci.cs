using System;

class Fibonacci
{

static void Main()
{
int  numTerms = 0;
Console.Write("Enter number of terms: ");
numTerms=Convert.ToInt32(Console.ReadLine());
int firstnum =0;
int secondnum =1;

Console.Write("{0} {1} ", firstnum, secondnum); // Print the first two terms

for(int i = 2; i < numTerms; i++) // Start loop from 2 because we already printed first two terms
{
    int nextTerm = firstnum + secondnum;

    Console.Write("{0} ", nextTerm);

    firstnum = secondnum;
    secondnum = nextTerm;
}



}

}