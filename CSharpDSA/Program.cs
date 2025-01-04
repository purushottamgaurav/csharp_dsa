using CSharpDSA;
using CSharpDSA.DataStructures;

Console.WriteLine("All Categories");
Console.WriteLine("----------------------");
Console.WriteLine("1- Data Structures");
Console.WriteLine("2- Algorithms");
Console.WriteLine("3- Design Patterns");
Console.WriteLine("4- Programs");
Console.WriteLine("----------------------");
Console.WriteLine("Enter your Category...[Press 1 for Data Structures]");
int category = int.Parse(Console.ReadLine());
Console.WriteLine("\n");

switch (category)
{
    case 1:
        foreach (DataStructureType type in Enum.GetValues(typeof(DataStructureType)))
        {
            Console.WriteLine($"{(int)type + 1}-{type}");
        }
        Console.WriteLine("Enter your Data Structure...[Press 1 for Array]");

        int subcategory = int.Parse(Console.ReadLine());
        switch (subcategory)
        {
            case 1:
                ArrayExample.Run();
                break;
            case 2:
                LinkedListExample.Run();
                break;

        }
        break;
    case 2:
        foreach (AlgorithmType type in Enum.GetValues(typeof(AlgorithmType)))
        {
            Console.WriteLine($"{(int)type + 1}-{type}");
        }
        Console.WriteLine("Enter your Data Structure...[Press 1 for Array]");
        break;
    case 3:
        foreach (DesignPatternType type in Enum.GetValues(typeof(DesignPatternType)))
        {
            Console.WriteLine($"{(int)type + 1}-{type}");
        }
        Console.WriteLine("Enter your Design Pattern...[Press 1 for Singleton]");
        break;
}
