// Display a message to the user asking them to guess the secret number.
// Display a prompt for the user's guess.
// Take the user's guess as input and save it as a variable.
// Display the user's guess back to the screen.

using System;

Console.WriteLine("Want to guess my secret number?");
Console.WriteLine("What is your guess?");

string guess = Console.ReadLine();

Console.WriteLine($"You just guessed {guess}");