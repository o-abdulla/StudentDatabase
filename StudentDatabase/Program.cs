// Student Database Lab

using System.Collections.Concurrent;
using System.ComponentModel.Design;



string[] names = { "Justin Jones", "Zach Buth", "Omar Abdulla", "Ethan Thomas", "Joe Heath", "Forrest Verellen", "Doug Chu", "Maya Araquil", "Shane Chastain", "Timothy Montague", "Maria Ragone" };
string[] towns = { "Columbus", "Grand Rapids", "Dearborn", "Rolla", "Howell", "Traverse City, MI", "Poughkeepsie", "West bloomfield", "Rochester Hills", "Clio", "Farmington Hills" };
string[] foods = { "Baja Blast", "Pizza", "Cheese Pizza", "Hot Wings", "Tacos", "Spaghetti", "Sushi", "Sinigang", "Pizza", "Mole", "Lasagna" };


int num = 0;
bool runProgram = true;
while (runProgram)
{
    
    // extra credit 1 showing option for list of students

    while (true)
    {
        Console.WriteLine("Would you like to see a list of all the students? yes/no");
        string list = Console.ReadLine().ToLower().Trim();
        if (list == "yes" || list == "y")
        {
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"{i}, {names[i]}");
            }
            break; 
        }
        else if (list == "no" || list == "n")
        {
            break;
        }
        else
        {
            Console.WriteLine("Thats not a valid entry");
        }
    }
    while (true)
    {
        // choosing a number which student to locate

        Console.WriteLine($"Enter a student number: 0 - {names.Length - 1}");
        num = int.Parse(Console.ReadLine());
        
        if (num >= 0 && num < names.Length - 1 )
        {
            Console.WriteLine(names[num]);
            break;
        }
        else
        {
            Console.WriteLine("Thats not a valid entry");
        }
    }

    while (true)
    {
        // continuing to proved extra info on hometown or favorite food
        
        Console.WriteLine($"Enter {names[num]} hometown or favorite food?");
        string response = Console.ReadLine().ToLower().Trim();

        if (response == "hometown" || response == "home")
        {
            Console.WriteLine(towns[num]);
            break;
        }
        else if (response == "favorite food" || response == "food" || response == "favorite")
        {
            Console.WriteLine(foods[num]);
            break;

        }
        else
        {
            Console.WriteLine("Invalid entry, please try again");
        }
   
    }

    
    while (true)
    {
        // asking if they would like to know about another student else close program

        Console.WriteLine("Would you like to learn about another student? yes/no");
        string answer = Console.ReadLine().ToLower().Trim();
        if (answer == "no" || answer == "n")
        {
            runProgram = false;
            Console.WriteLine("Have a nice day!");
            break;
        }
        else if (answer == "yes" || answer == "y")
        {
            runProgram = true;
            break;
        }
        else
        {
            Console.WriteLine("Invalid response please enter yes or no");
        }
    }
}