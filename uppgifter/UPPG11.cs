using System;

class UPPG11
{
    static void Main()
    {
        //enter a message
        Console.WriteLine("Please enter a message:");
        var message = Console.ReadLine();

        //the message in the original order
        Console.WriteLine("\nMessage in original order:");
        Console.WriteLine(message);

        //the message in reverse order
        char[] messageArray = message.ToCharArray();
        Array.Reverse(messageArray);
        string reversedMessage = new string(messageArray);
        Console.WriteLine("\nMessage in reverse order:");
        Console.WriteLine(reversedMessage);

        //the message letter by letter
        Console.WriteLine("\nMessage letter by letter:");
        foreach (char c in message)
        {
            Console.WriteLine(c);
        }

        //the reversed message letter by letter
        Console.WriteLine("\nReversed message letter by letter:");
        foreach (char c in reversedMessage)
        {
            Console.WriteLine(c);
        }
    }
}