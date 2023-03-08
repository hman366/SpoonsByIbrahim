// See https://aka.ms/new-console-template for more information
using System.Xml.Linq;

Console.WriteLine("************Conversion Table Program************");
string playAgain;
do
{


    int increment = 0;
    string inputValue;
    bool positiveInt = false;
    Console.Write("Please write the increment to be used for your table (must be positive): ");
    do
    {

        inputValue = Console.ReadLine();
        if ((int.TryParse(inputValue, out increment)) && (increment > 0) && (increment <= 30))
        {


            positiveInt = true;
        }
        else
        {
            Console.Write("Invalid increment! Please enter a positive number.");
            Console.Write("\nPlease write the increment to be used for your table (must be positive): ");
            positiveInt = false;
        }

    } while (!positiveInt);
    Console.WriteLine("Tea Spoons Table Spoons");
    Console.WriteLine("============ ============");
    for (int i = 1; i <= 30; i += increment)
    {
        double teaSpoon = i;
        double tableSpoon = i / 3.0;
        Console.WriteLine("{0, -10} {1, 15}", teaSpoon, tableSpoon);

    }
    Console.Write("Would you like to run the program again (Y-Yes): ");
    playAgain = Console.ReadLine();
} while (playAgain.ToUpper() == "Y");
Console.Write("Thank you for playing!");



