using System;
using BinaryNamespace;

class Program
{
    static void Main()
    {
        string input = " ";
        Console.WriteLine("\n------------------------------------");
        Console.WriteLine("BINÄRZAHLEN-KONVERTIERER");
        Console.WriteLine("------------------------------------");
        
        BinaryConverter converter = new BinaryConverter();

        Console.Write("Gib eine Binärzahl ein: ");
        input = Console.ReadLine();

        int dezimal = converter.Convert(input);
        Console.WriteLine("Dezimalwert: " + dezimal + "\n");
    }
}

