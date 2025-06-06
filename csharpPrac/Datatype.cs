using System;

class Datatype{

public static bool SameDatatype(object data1,object data2)
{

return data1.GetType() == data2.GetType();
}


static void Main()
{

int data1 = 22;
bool data2 = true;
int data3 = 14;


bool n = SameDatatype(data1,data3);

Console.WriteLine(n);

}


}