// See https://aka.ms/new-console-template for more information
using System.Transactions;
Console.WriteLine("Hello World");
//These Int x y z are unassigned intergerswhich will be assinged later.
int x;
int y;
int z;
// These lines of code ask the user to assign a number to the Intergers.
Console.WriteLine("Enter your num1:");
x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Your num1 is: " + x);
Console.WriteLine("Enter your num2:");
y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Your Num2 is: "+ y);
Console.WriteLine("Enter Your Num3");
z = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Your Num1 is" + z);
// These two lines of code add x+y+z and mutliplies X and A. While assigning what they equal to an varible.
int a = x + y + z;
int b = x * a;
// These lines of code prints to the terminal diffrent math problems.
Console.WriteLine(a);
Console.WriteLine(y - x);
Console.WriteLine(b);
Console.WriteLine(x % b);
// This line of code ask the user for there name and prints it to the terminal.
Console.WriteLine("What is your name?");
string userName = Console.ReadLine();
Console.WriteLine("It is nice to meet you, " + userName + '!');