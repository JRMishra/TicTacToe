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
            TicTacToeGame ticTacToeGame = new TicTacToeGame();
            ticTacToeGame.StartGame();
            ticTacToeGame.UsersChoice();
            ticTacToeGame.ShowBoard();
            usersChance= ticTacToeGame.TossToStartFirst();
            while(!ticTacToeGame.IsGameOver())
            {
                if (!usersChance)
                    Console.WriteLine("Winning move for system " + ticTacToeGame.CheckWinningMove());
                ticTacToeGame.UserMove();
                ticTacToeGame.MakeMove(usersChance);

                usersChance = !usersChance;
            }
        }
    }
}
