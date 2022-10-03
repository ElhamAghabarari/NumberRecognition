// See https://aka.ms/new-console-template for more information
using static System.Console;

int num = 0;
while (true)
{
    Write("Please enter a number:");
    if (Int32.TryParse(ReadLine(), out num)) break;
    WriteLine("error format");
}

for (int i = 0; i < num; i++)
{
    Console.WriteLine("{0} {1}",(i % 2==0?"$":"#"),i);
}

