using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to TicTcToe Game");
            Console.WriteLine("-------------------------");

            bool usersChance;
            int userChoice = 1;
            int index;
            TicTacToeGame ticTacToeGame = new TicTacToeGame();
            do
            {
                ticTacToeGame.StartGame();
                ticTacToeGame.UsersChoice();
                ticTacToeGame.ShowBoard();
                usersChance = ticTacToeGame.TossToStartFirst();
                while (!ticTacToeGame.IsTheGameOver)
                {
                    if (usersChance)
                    {
                        Console.WriteLine("Player's chance");
                        Console.WriteLine("----------------");
                        index = ticTacToeGame.UserMove();
                        
                    }
                    else
                    {
                        Console.WriteLine("System's chance");
                        Console.WriteLine("----------------");
                        index = ticTacToeGame.SuggestIndex();
                    }
                    ticTacToeGame.MakeMove(usersChance, index);

                    usersChance = !usersChance;
                }

                Console.WriteLine("Enter\n" +
                "1 : Play Again\n" +
                "0 : Exit");
                userChoice = Int32.Parse(Console.ReadLine());
            } while (userChoice == 1);
        }
    }
}
