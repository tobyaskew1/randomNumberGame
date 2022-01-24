// See https://aka.ms/new-console-template for more information
//number guessing game
//calling the random class to generate my random number
Random rnd = new Random();
//while true loop lets the game run until the user closes, instead of stopping after 1 guess.
while (true)
{
    //generating  a random int number between 1 and 11
    int number = rnd.Next(1, 11);
    //asking the user for a number 
    Console.WriteLine("Enter your number between 1 & 10 here: ");
    int user = Convert.ToInt32(Console.ReadLine());
    //printing the random number
    Console.WriteLine(number);
    //if statement to check if the number the user added is a valid number
    if (user <= 10)
    {
        //if valid the if statement checks to see if the user won or not
        if (user == number)
        {
            Console.WriteLine("You guessed it right! Congratulations!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
    //if the number is invalid it gives a message to the user to tell them.
    else
    {
        Console.WriteLine("invalid number. It must be equal to or less than 10.");
    }


}

