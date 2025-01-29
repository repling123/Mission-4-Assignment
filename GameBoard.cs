using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Mission_4_Assignment;

namespace Mission_4_Assignment
{
    internal class GameBoard
    {
        // Function to display the Tic Tac Toe array board
        public void PrintBoard(char[,] board)
        {
            int rows = board.GetLength(0);
            int cols = board.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(board[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        // Function to keep track of game results
        public char CheckWinner(char[,] board)
        {
            int boardSize = board.GetLength(0);
            char outcome = 'N';
            // Check win on row
            for (int i = 0; i < boardSize; i++)
            {
                if (board[i, 0] != '\0' && board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
                {
                    outcome = board[i, 0];
                }
            }
            // Check columns
            for (int j = 0; j < boardSize; j++)
            {
                if (board[0, j] != '\0' && board[0, j] == board[1, j] && board[1, j] == board[2, j])
                {
                    outcome = board[0, j];
                }
            }

            // Check main diagonal
            if (board[0, 0] != '\0' && board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
            {
                outcome = board[0, 0];
            }

            // Check secondary diagonal
            if (board[0, 2] != '\0' && board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
            {
                outcome = board[0, 2];
            }

            // Init boardFilled as 0 and increment when space is taken
            int boardFilled = 0;
            if (outcome == 'N')
            {
                for (int i = 0; i < boardSize; i++)
                {
                    for (int j = 0; j < boardSize; j++)
                    {
                        if (board[i, j] < 49 || board[i, j] > 58) // Check if not 1-9
                        {
                            boardFilled++;
                        }
                    }
                }
                if (boardFilled >= 9)
                {
                    outcome = 'C';
                }
            }
            return outcome;
        }
    }
}
