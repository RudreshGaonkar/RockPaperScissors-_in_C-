Random random = new Random();
bool playAgain = true;


while (playAgain)
{
    string playerChoice = " ";
    string computerChoice = " ";

    while (playerChoice != "ROCK" && playerChoice != "PAPER" && playerChoice != "SCISSORS")
    {
        Console.WriteLine("\t__________________________________________\t");
        Console.WriteLine("\t Rock, Paper, Scissors Game\t");
        Console.WriteLine("\t__________________________________________\t\n");
        Console.Write("Enter your choice: ");
        playerChoice = Console.ReadLine();
        playerChoice = playerChoice.ToUpper(); 

        int randNum = random.Next(1, 4);

        switch (randNum)
        {
            case 1:
                computerChoice = "ROCK";
                break;
            case 2:
                computerChoice = "PAPER";
                break;
            case 3:
                computerChoice = "SCISSORS";
                break;
            default: Console.WriteLine("there was some error"); break;
        }

        if (playerChoice == "ROCK")
        {
            if (computerChoice == "ROCK")
            {
                Console.WriteLine("Tie");
            }
            else if (computerChoice == "PAPER")
            {
                Console.WriteLine("You lose");
            }
            else if (computerChoice == "SCISSORS")
            {
                Console.WriteLine("You Win!");
            }
        }

        else if (playerChoice == "PAPER")
        {
            if (computerChoice == "ROCK")
            {
                Console.WriteLine("You win!");
            }
            else if (computerChoice == "PAPER")
            {
                Console.WriteLine("Tie");
            }
            else if (computerChoice == "SCISSORS")
            {
                Console.WriteLine("You lose");
            }
        }

        else if (playerChoice == "SCISSORS")
        {
            if (computerChoice == "ROCK")
            {
                Console.WriteLine("You lose");
            }
            else if (computerChoice == "PAPER")
            {
                Console.WriteLine("You win!");
            }
            else if (computerChoice == "SCISSORS")
            {
                Console.WriteLine("Tie");
            }
        }

        Console.WriteLine("\n You choose "+playerChoice+" and Computer choose "+computerChoice);

        Console.WriteLine("\n__________________________________________\n");

        Console.Write("Want to play again (Y/N): ");
        char playGame = Convert.ToChar(Console.ReadLine());

        if (playGame == 'Y' || playGame == 'y')
        {
            playAgain = true;
        }
        else if (playGame == 'N' || playGame == 'n')
        {
            playAgain = false;
        }
        else
        {
            Console.WriteLine("\n Invalid option");
        }
        //break;
        Console.WriteLine("\n__________________________________________\n");
    }
}