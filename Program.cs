using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to TicTcToe Game");
            Console.WriteLine("-------------------------");

            TicTacToeGame ticTacToeGame = new TicTacToeGame();
            ticTacToeGame.StartGame();
            ticTacToeGame.UsersChoice();
            ticTacToeGame.ShowBoard();
            ticTacToeGame.TossToStartFirst();
            if(ticTacToeGame.UserWonToss)
            {
                ticTacToeGame.UserMove();
                ticTacToeGame.MakeMove();
            }
            else
            {
                ticTacToeGame.UserMove();
                ticTacToeGame.MakeMove();
            }
        }
    }
}
