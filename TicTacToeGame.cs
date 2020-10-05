using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class TicTacToeGame
    {
        char[] _board;
        char _userChoice;
        char _systemChoice;
        int currUserInput;
        bool _userWonToss;
        int _filledCell=0;

        public TicTacToeGame()
        {
            _board = new char[10];
        }

        public char[] Board { get => _board; }
        public char UserChoice { get => _userChoice; }
        public char SystemChoice { get => _systemChoice; }
        public bool UserWonToss { get => _userWonToss; }

        public void StartGame()
        {
            for (int i = 1; i < 10; i++)
            {
                _board[i] = ' ';
            }
        }

        public void UsersChoice()
        {
            Console.Write("Enter your choice to play further\n 'X' or 'O' ? ");
            char ch = Convert.ToChar(Console.ReadLine());

            if (ch == 'X' || ch == 'O')
            {
                _userChoice = ch;
                if (ch == 'X')
                    _systemChoice = 'O';
                else
                    _systemChoice = 'X';
            }
            else
            {
                Console.WriteLine("Wrong Choice");
                UsersChoice();
            }
        }

        public void ShowBoard()
        {
            for (int i = 1; i < 10; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write(_board[i]);
                    Console.WriteLine("\n----------");
                }
                else
                {
                    Console.Write(_board[i] + " | ");
                }
            }
        }

        public void UserMove()
        {
            Console.WriteLine("Enter index (1-9) to mark your choice :");
            int userMove = Convert.ToInt32(Console.ReadLine());
            if (userMove > 0 && userMove < 10)
            {
                if (_board[userMove] == ' ')
                    currUserInput = userMove;   
                else
                {
                    Console.WriteLine("The given Index isn't empty");
                    UserMove();
                }
            }
            else
            {
                Console.WriteLine("Index should be between 1 to 9");
                UserMove();
            }
        }

        public void MakeMove(bool isUser)
        {
            _board[currUserInput] =isUser ? _userChoice : _systemChoice;
            _filledCell++;
            ShowBoard();
        }

        public bool TossToStartFirst()
        {
            Console.WriteLine("Choose Head / Tail to start first");
            string userChoice = Console.ReadLine().ToLower();
            string[] coin = new string[2] { "head", "tail" };
            Random toss = new Random();
            _userWonToss= (coin[toss.Next(0, 2)] == userChoice);
            if (_userWonToss)
                Console.WriteLine("You won the toss");
            else
                Console.WriteLine("You lose the toss");

            return _userWonToss;
        }

        public bool IsGameOver()
        {
            bool isUserWinner = ((_board[1] == _userChoice && _board[2] == _userChoice && _board[3] == _userChoice) ||
                          (_board[4] == _userChoice && _board[5] == _userChoice && _board[6] == _userChoice) ||
                          (_board[7] == _userChoice && _board[8] == _userChoice && _board[9] == _userChoice) ||
                          (_board[1] == _userChoice && _board[4] == _userChoice && _board[7] == _userChoice) ||
                          (_board[2] == _userChoice && _board[5] == _userChoice && _board[8] == _userChoice) ||
                          (_board[3] == _userChoice && _board[6] == _userChoice && _board[9] == _userChoice) ||
                          (_board[1] == _userChoice && _board[5] == _userChoice && _board[9] == _userChoice) ||
                          (_board[3] == _userChoice && _board[5] == _userChoice && _board[7] == _userChoice));
            bool isSystemWinner = ((_board[1] == _systemChoice && _board[2] == _systemChoice && _board[3] == _systemChoice) ||
                          (_board[4] == _systemChoice && _board[5] == _systemChoice && _board[6] == _systemChoice) ||
                          (_board[7] == _systemChoice && _board[8] == _systemChoice && _board[9] == _systemChoice) ||
                          (_board[1] == _systemChoice && _board[4] == _systemChoice && _board[7] == _systemChoice) ||
                          (_board[2] == _systemChoice && _board[5] == _systemChoice && _board[8] == _systemChoice) ||
                          (_board[3] == _systemChoice && _board[6] == _systemChoice && _board[9] == _systemChoice) ||
                          (_board[1] == _systemChoice && _board[5] == _systemChoice && _board[9] == _systemChoice) ||
                          (_board[3] == _systemChoice && _board[5] == _systemChoice && _board[7] == _systemChoice));

            bool over = (_filledCell == 9);

            if (isUserWinner)
                Console.WriteLine("User won it");
            else if (isSystemWinner)
                Console.WriteLine("System Won it");
            else if(over)
                Console.WriteLine("No more free move\nTie...");
            else
                Console.WriteLine("Continue...");

            return (isUserWinner || isSystemWinner || over);

        }

        public int CheckWinningMove()
        {
            if (_board[1]==' ' && ((_board[2] == _systemChoice && _board[3] == _systemChoice) ||
                (_board[5] == _systemChoice && _board[9] == _systemChoice) ||
                (_board[4] == _systemChoice && _board[7] == _systemChoice)))
                return 1;

            if (_board[2] == ' ' && ((_board[1] == _systemChoice && _board[3] == _systemChoice) ||
                (_board[5] == _systemChoice && _board[8] == _systemChoice)))
                return 2; 

            if (_board[3] == ' ' && ((_board[1] == _systemChoice && _board[2] == _systemChoice) ||
                (_board[6] == _systemChoice && _board[9] == _systemChoice) ||
                (_board[5] == _systemChoice && _board[7] == _systemChoice)))
                return 3;

            if (_board[4] == ' ' && ((_board[5] == _systemChoice && _board[6] == _systemChoice) ||
               (_board[1] == _systemChoice && _board[7] == _systemChoice)))
                return 4;

            if (_board[5] == ' ' && ((_board[4] == _systemChoice && _board[6] == _systemChoice) ||
               (_board[2] == _systemChoice && _board[8] == _systemChoice) ||
               (_board[1] == _systemChoice && _board[9] == _systemChoice) ||
               (_board[3] == _systemChoice && _board[7] == _systemChoice)))
                return 5;

            if (_board[6] == ' ' && ((_board[4] == _systemChoice && _board[5] == _systemChoice) ||
               (_board[3] == _systemChoice && _board[9] == _systemChoice)))
                return 6;

            if (_board[7] == ' ' && ((_board[1] == _systemChoice && _board[4] == _systemChoice) ||
               (_board[8] == _systemChoice && _board[9] == _systemChoice) ||
               (_board[3] == _systemChoice && _board[5] == _systemChoice)))
                return 7;

            if (_board[8] == ' ' && ((_board[2] == _systemChoice && _board[5] == _systemChoice) ||
               (_board[7] == _systemChoice && _board[9] == _systemChoice)))
                return 8;

            if (_board[9] == ' ' && ((_board[1] == _systemChoice && _board[5] == _systemChoice) ||
               (_board[7] == _systemChoice && _board[8] == _systemChoice) ||
               (_board[3] == _systemChoice && _board[6] == _systemChoice)))
                return 9;

            return 0;
        }
        
        public int BlockWinningMove()
        {
            if (_board[1]==' ' && ((_board[2] == _userChoice && _board[3] == _userChoice) ||
                (_board[5] == _userChoice && _board[9] == _userChoice) ||
                (_board[4] == _userChoice && _board[7] == _userChoice)))
                return 1;

            if (_board[2] == ' ' && ((_board[1] == _userChoice && _board[3] == _userChoice) ||
                (_board[5] == _userChoice && _board[8] == _userChoice)))
                return 2; 

            if (_board[3] == ' ' && ((_board[1] == _userChoice && _board[2] == _userChoice) ||
                (_board[6] == _userChoice && _board[9] == _userChoice) ||
                (_board[5] == _userChoice && _board[7] == _userChoice)))
                return 3;

            if (_board[4] == ' ' && ((_board[5] == _userChoice && _board[6] == _userChoice) ||
               (_board[1] == _userChoice && _board[7] == _userChoice)))
                return 4;

            if (_board[5] == ' ' && ((_board[4] == _userChoice && _board[6] == _userChoice) ||
               (_board[2] == _userChoice && _board[8] == _userChoice) ||
               (_board[1] == _userChoice && _board[9] == _userChoice) ||
               (_board[3] == _userChoice && _board[7] == _userChoice)))
                return 5;

            if (_board[6] == ' ' && ((_board[4] == _userChoice && _board[5] == _userChoice) ||
               (_board[3] == _userChoice && _board[9] == _userChoice)))
                return 6;

            if (_board[7] == ' ' && ((_board[1] == _userChoice && _board[4] == _userChoice) ||
               (_board[8] == _userChoice && _board[9] == _userChoice) ||
               (_board[3] == _userChoice && _board[5] == _userChoice)))
                return 7;

            if (_board[8] == ' ' && ((_board[2] == _userChoice && _board[5] == _userChoice) ||
               (_board[7] == _userChoice && _board[9] == _userChoice)))
                return 8;

            if (_board[9] == ' ' && ((_board[1] == _userChoice && _board[5] == _userChoice) ||
               (_board[7] == _userChoice && _board[8] == _userChoice) ||
               (_board[3] == _userChoice && _board[6] == _userChoice)))
                return 9;

            return 0;
        }
    }
}
