// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata.Ecma335;


Console.WriteLine("Welcome to HighLo Challenge!");
Console.WriteLine("Please enter your name.");
string name = Console.ReadLine();
Console.WriteLine($" {name}, How many turns will it take your to guess the right number?");


//random class
Random rnd = new Random();


int answer = 0;
int turns = 0;
//randomnumber generator
int guess = rnd.Next(1, 101);
guess = rnd.Next(1,101);
Console.WriteLine(guess);// I like to put this in to confirm the random number when I'm testing. I'll comment it out later.
do
{
    Console.WriteLine("Guess a number between 1 and 100");
    answer = int.Parse(Console.ReadLine());

    turns++;

    if (answer < guess)
    {
        Console.WriteLine("Too low. Guess again.");

    }
    else if (answer > guess)
    {
        Console.WriteLine("Too high. Guess again.");
    }
} while (answer != guess);
    
    {

    }

    Console.WriteLine($"Congratulations! It took {turns} guesses to get the right answer.");

