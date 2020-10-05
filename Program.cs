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
                if (usersChance)
                {
                    Console.WriteLine("Player's chance");
                    Console.WriteLine("----------------");
                    int userIndex = ticTacToeGame.UserMove();
                    ticTacToeGame.MakeMove(usersChance,userIndex);
                }
                else
                {
                    Console.WriteLine("System's chance");
                    Console.WriteLine("----------------");
                    int userIndex = ticTacToeGame.SuggestIndex();
                    ticTacToeGame.MakeMove(usersChance, userIndex);
                }   
                usersChance = !usersChance;
            }
        }
    }
}
