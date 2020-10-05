using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class TicTacToeGame
    {
        char[] _board;

        public TicTacToeGame()
        {
            _board = new char[10];
        }

        public char[] Board { get => _board; set => StartGame(); }

        public void StartGame()
        {
            for(int i=1;i<10;i++)
            {
                _board[i] = ' ';
            }
            return;
        }

    }
}
