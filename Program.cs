// Display a message to the user asking them to guess the secret number.
// Display a prompt for the user's guess.
// Take the user's guess as input and save it as a variable.
// Display the user's guess back to the screen.

using System;

main();
// run main function
void main()
// all funcxtions are called in main
{

    Console.WriteLine("Want to guess my secret number?");
    Console.WriteLine("What is your guess?");

    string userGuess = Console.ReadLine();
    string correctNumber = "42";

    if (userGuess == correctNumber)
    {
        Console.WriteLine("Yaaas Youz righttt!");
    }
    else
    {
        Console.WriteLine("Nah son, try again");
    }
}