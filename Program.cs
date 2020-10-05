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
        }
    }
}
