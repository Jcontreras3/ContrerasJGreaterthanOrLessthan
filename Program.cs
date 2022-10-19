//Jovann Contreras
//Date 10/18/2022
//Checking if numbers are greater than, less than or equal too with data validation.


Console.Clear();
string playAgain = "yes";
while (playAgain == "yes")
{

    int num1 = 0;
    int num2 = 0;
    bool numberOne = false;
    while (!numberOne)
    {
        Console.WriteLine("Enter first number");

        numberOne = int.TryParse(Console.ReadLine(), out num1);
        if (numberOne)
        {
            Console.WriteLine($"Your first number: {num1}");
        }
        else
        {
            Console.WriteLine($"Not a number");
        }


    }

    bool numberTwo = false;
    while (!numberTwo)
    {
        Console.WriteLine("Enter second number");

        numberTwo = int.TryParse(Console.ReadLine(), out num2);
        if (numberTwo)
        {
            Console.WriteLine($"Your second number: {num2}");
        }
        else
        {
            Console.WriteLine($"Not a number");
        }

    }




    if (num1 == num2)
    {
        Console.WriteLine($"{num1} and {num2} are equal to eachother");
    }
    if (num1 > num2)
    {
        Console.WriteLine($"{num1} is greater than {num2}");
    }
    if (num1 < num2)
    {
        Console.WriteLine($"{num1} is less than {num2}");
    }

    Console.WriteLine("Would you like to try again? type in Yes to retry or No to quit");

    string playAgainInput = "Nothing";

    while (playAgainInput != "yes" || playAgainInput != "no")
    {
        playAgainInput = Console.ReadLine().ToLower();
        if (playAgainInput == playAgain)
        {
            break;
        }
        else if (playAgainInput == "no")
        {
            Console.WriteLine("Thanks for playing!");
            playAgain = playAgainInput;
            break;

        }
        else
        {
            Console.WriteLine("Invalid input please type in yes or no");
            playAgainInput = "invalid";
        }

    }
}