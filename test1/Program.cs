using static System.Console;

int num = 0;

while (true)
{
    Write("Please enter a number:");
    if (int.TryParse(ReadLine(), out num)) break;
    WriteLine("error format");
}

for (int i = 0; i < num; i++)
{
    WriteLine($"{(i % 2 == 0 ? '$' : '#')}{i}");
}

