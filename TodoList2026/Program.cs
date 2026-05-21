
//using System.ComponentModel.Design;
//using System.Net.Security;

//Console.WriteLine("Hello, World!");
//Console.ReadKey();

//bool IsOn = true;

//Console.WriteLine("starting app");
//Console.WriteLine("what would you like to do today");
//Console.WriteLine("type S to see all TODOS");
//Console.WriteLine("type A to add a TODO");
//Console.WriteLine("type R to remove a TODO ");
//Console.WriteLine("type E to exit");

//string userinput = Console.ReadLine();
//var userTodos = "";



//Console.WriteLine(userinput);


////Currently this while statement will indeffo print the selected input to the terminal 
//while (IsOn)
//{
//    if (userinput == "S")
//    {
//        PrintSelectedOption("See all Todos", userinput);
//    }
//    else if (userinput == "A")
//    {
//        PrintSelectedOption("Add TODO", userinput);
//    }
//    else if (userinput == "R")
//    {
//        PrintSelectedOption("Remove TODO", userinput);
//    }
//    else if (userinput == "E")
//    {
//        PrintSelectedOption("Exiting program", userinput);
//        Console.WriteLine("Exiting the program...");
//        IsOn = false;

//    }
//    else
//    {
//        Console.WriteLine("Unrecognized input. Exiting the program...");
//        IsOn = false;
//    }
//}

//Console.WriteLine("The app is closed. Press any key to exit.");
//Console.ReadKey();

//void PrintSelectedOption(string selectedOption, string userinput)
//{
//    Console.WriteLine($"{userinput} selected option: " + selectedOption);
//}



//dotnet run "run the program make sure pointed at folder that contains .csproj extention"
//dotnet build "build the application without running it"
//dotnet new class -n MyNewClass "create a new file for this class"
//*/




//Count to one million timer
using System.Diagnostics;
Console.WriteLine("press any key to start");
Console.ReadKey();

var number = 0;
var countTil = 1000000;
Stopwatch watch = Stopwatch.StartNew();
while (number < countTil)
{
    number++;
    //Console.WriteLine(number); //remove this time as it is slows down the whole operation
}
watch.Stop();
Console.WriteLine("exit loop");
Console.WriteLine($"Time elapsed: {watch.Elapsed.TotalMilliseconds:F4} milliseconds");
Console.WriteLine($"Time elapsed: {watch.Elapsed.TotalSeconds:F2} seconds");
Console.WriteLine($"Time elapsed: {watch.ElapsedMilliseconds} milliseconds");

Console.WriteLine($"counts per millisecond: {countTil / watch.Elapsed.TotalMilliseconds}");

Console.ReadKey();


////Exerise 
//using System.Reflection.Metadata.Ecma335;
//using System.Threading.Channels;

/////*terminal commands#
//int CalculateSumOfNumbersBetween(int firstNumber, int lastNumber)
//{

//    int currentNumber = firstNumber;
//    int sum = 0; 
//    while (currentNumber <= lastNumber)
//    {
//        sum += currentNumber;
//        currentNumber++;
//    }
//    return sum;
//}

//Console.WriteLine("enter the first number");
//int num1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("enter the second number");
//int num2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(CalculateSumOfNumbersBetween(num1, num2));
//Console.ReadKey();

// the difference between ++i and i++ 
//int i = 5;
//Console.WriteLine(i++); // prints 5, then i becomes 6
//Console.WriteLine(i);   // prints 6

//int j = 5;
//Console.WriteLine(++j); // j becomes 6, then prints 6
//Console.WriteLine(j);   // prints 6

//Console.ReadKey();


//Excerse

//static string RepeatCharacter(char character, int targetLength)
//{
//    string result = "";
//    do
//    {
//        result += character;
//    }
//    while (result.Length < targetLength);
//    return result;
//}

//Console.WriteLine("Enter the char");
//char character = Convert.ToChar(Console.ReadLine());
//Console.WriteLine("enter the targe length");
//int targetLength = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine(RepeatCharacter(character, targetLength));
//Console.ReadKey(); 