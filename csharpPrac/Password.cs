using System;

class password
{

static void Main()
{
String username="jose";
String pword="pass";

String entername="";
String enterpword="";
int trial = 3;

bool isvalid = false;

while( trial != 0)
{
Console.Write("Enter Username: ");
entername = Console.ReadLine();
Console.Write("Enter Password: ");
enterpword = Console.ReadLine();

if(entername.Equals(username) && enterpword.Equals(pword)){
isvalid = true;
break;
}else{
trial--;
if(trial != 0)
Console.WriteLine("You have {0} tries remaining", trial);

}

}


if(isvalid)
Console.WriteLine("Welcome");
else
Console.WriteLine("Sorry,Account blocked.Contact helpdesk");

}

}