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

            Console.Write("Enter your choice to play further\n 'X' or 'O' ? ");
            char userChoice = Convert.ToChar(Console.ReadLine());
            ticTacToeGame.UsersChoice(userChoice);

        }
    }
}
