using System;
using System.Collections;

class HashPrac1{

static void Main()
{

Hashtable employees = new Hashtable();
String search = "";
String name ="";
int salary;
int options = 0;
employees.Add("John",50000);
employees.Add("James",10000);
employees.Add("Kenneth",80000);



foreach (DictionaryEntry i in employees)
{
    Console.WriteLine("Employee: "+i.Key+" , Salary: "+i.Value);
}



while(options != 5){

Console.WriteLine("1. View all  Employees");
Console.WriteLine("2. Search Employee");
Console.WriteLine("3. Add new Employee");
Console.WriteLine("4. Remove Employee");
Console.WriteLine("5. Exit");
Console.Write("Choose[1-5] : ");
options=Convert.ToInt32(Console.ReadLine());

switch(options){

case 1:
foreach (DictionaryEntry i in employees)
{
    Console.WriteLine("Employee: "+i.Key+" , Salary: "+i.Value);
}
break;


case 2:

Console.Write("Enter Employee Name: ");
search = Console.ReadLine();
if(employees.ContainsKey(search))
{
Console.WriteLine("Name: "+search+" Salary: "+employees[search]);

}else{

Console.WriteLine("Employee not found");
}

break;



case 3:

Console.Write("Enter new Employee  name: ");
name=Console.ReadLine();

Console.Write("Enter new Employee  salary: ");
salary=Convert.ToInt32(Console.ReadLine());

employees.Add(name,salary);

break;


case 4:
Console.Write("Enter the name of the employee you want to remove: ");
name=Console.ReadLine();
if(employees.ContainsKey(name))
employees.Remove(name);
else
Console.WriteLine("Name not found");
break;


case 5:

break;


default:
break;


}
}

}



}