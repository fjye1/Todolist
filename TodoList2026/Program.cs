
using System.ComponentModel.Design;
using System.Net.Security;

Console.WriteLine("Hello, World!");
Console.ReadKey();

bool IsOn = true;

Console.WriteLine("starting app");
Console.WriteLine("what would you like to do today");
Console.WriteLine("type S to see all TODOS");
Console.WriteLine("type A to add a TODO");
Console.WriteLine("type R to remove a TODO ");
Console.WriteLine("type E to exit");

string userinput = Console.ReadLine();
var userTodos = "";



Console.WriteLine(userinput);


//Currently this while statement will indeffo print the selected input to the terminal 
while (IsOn)
{
    if (userinput == "S")
    {
        PrintSelectedOption("See all Todos", userinput);
    }
    else if (userinput == "A")
    {
        PrintSelectedOption("Add TODO", userinput);
    }
    else if (userinput == "R")
    {
        PrintSelectedOption("Remove TODO", userinput);
    }
    else if (userinput == "E")
    {
        PrintSelectedOption("Exiting program", userinput);
        Console.WriteLine("Exiting the program...");
        IsOn = false;

    }
    else
    {
        Console.WriteLine("Unrecognized input. Exiting the program...");
        IsOn = false;
    }
}

Console.WriteLine("The app is closed. Press any key to exit.");
Console.ReadKey();

void PrintSelectedOption(string selectedOption, string userinput)
{
    Console.WriteLine($"{userinput} selected option: " + selectedOption);
}


int Add (int a, int b)
{
    return a + b;
}