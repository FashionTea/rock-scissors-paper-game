


bool newGame = true;


while (newGame)
{
    Console.WriteLine("Welcome to rock, scissors,paper game! Please enter 1 if you chose rock, 2 for paper,3 for scissor");
    string userChoice = Console.ReadLine();
    int user = int.Parse(userChoice);
    Random rnd = new Random();
    int pC = rnd.Next(1, 4);

    if (pC == 1)
    {
        if (user == 1)
        {
            Console.WriteLine("You chose rock. The computer also chose rock");
            Console.WriteLine("It is a tie game.");
        }
        else if (user == 2)
        {
            Console.WriteLine("You chose paper.The computer chose paper");
            Console.WriteLine("It is a tie game.");

        }
        else if (user == 3)
        {
            Console.WriteLine("You chose scissors.The computer chose scissors");
            Console.WriteLine("It is a tie game.");
        }
        else
        {
            Console.WriteLine("You must enter number 1 ,2 , or 3!!");

        }

    }

    else if (pC == 2)
    {
        if (user == 1)
        {
            Console.WriteLine("You chose rock.The computer chose paper");
            Console.WriteLine("Sorry you lose,paper beat rock!");

        }
        else if (user == 2)
        {
            Console.WriteLine("You chose paper.The computer chose scissors");
            Console.WriteLine("Sorry you lose,scissors beat paper!");

        }
        else if (user == 3)
        {
            Console.WriteLine("You chose scissors.The computer chose rock");
            Console.WriteLine("Sorry you lose,rock beats scissors!");
        }
        else
        {
            Console.WriteLine("You must enter number 1 ,2 , or 3!!");
        }
    }
    else if (pC == 3)
    {
        if (user == 1)
        {
            Console.WriteLine("You chose rock.The computer chose scissors");
            Console.WriteLine("You win,rock beats scissors!");

        }
        else if (user == 2)
        {
            Console.WriteLine("You chose paper.The computer chose rock");
            Console.WriteLine("You win,paper beats rock!");

        }
        else if (user == 3)
        {
            Console.WriteLine("You chose scissors.The computer chose paper");
            Console.WriteLine("You win,scissors beat paper!");

        }
        else
        {
            Console.WriteLine("You must enter number 1 ,2 , or 3!!");

        }

    }
    Console.WriteLine("Do you want to play one more time? Please enter Y or N");
    string again = Console.ReadLine();
    if(again.ToLower() == "n")
    {
        Console.WriteLine("bye, have a good day!");
        newGame = false; }
    else if(again.ToLower()=="y")
    { newGame = true; }
    else
    { Console.WriteLine("Guess you don't want to play, bye!!");
        newGame = false;
    }
}