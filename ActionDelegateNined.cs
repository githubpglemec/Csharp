using System;

namespace ncit_hari
{
    internal class ActionDelegateNined
    {
        // Method to display a message
        public static void DisplayMessage(string message)
        {
            Console.WriteLine("Message: " + message);
        }

        // Method to display the current date and time
        public static void DisplayDateTime()
        {
            Console.WriteLine("Current Date and Time: " + DateTime.Now);
        }

        // Main method
        public static void Main(string[] args)
        {
            // Action delegate declaration
            Action<string> displayMessageAction = DisplayMessage;
            Action displayDateTimeAction = DisplayDateTime;

            // Call the Action delegates
            displayMessageAction("Hello, World!");
            displayDateTimeAction();

            // Additional information
            Console.WriteLine("\nLab No.: 9");
            Console.WriteLine("Name: Hari Prasad Gyawali");
            Console.WriteLine("Roll No./Section: 06");
        }
    }
}
