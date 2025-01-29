// Group 1-11
// 1/29/25
// Jaxon, Boston, Sean, Russell
// Tic Tac Toe Game

using Mission_4_Assignment;

// Public Program Class
public class Program
{
    public static void Main(string[] args)
    {
        // Welcome users to game
        Console.WriteLine("Welcome to Tic Tac Toe");
        
        // Create the board
        char[,] board =
        {
            { '1', '2', '3' },
            { '4', '5', '6' },
            { '7', '8', '9' }
        };

        // Instance of GameBoard and booleans for while loops
        GameBoard gb = new GameBoard();
        
        bool playerone = true;
        bool endGame = false;
       
        
        while (!endGame)
        {
            // Players 1 makes their move
            if (playerone)
            {
                bool validMove = false;
                // Asks for player one input
                Console.WriteLine(' ');
                Console.WriteLine("Player one place an 'X' (e.g. 1)");
                
                // Call the print board method 
                gb.PrintBoard(board);
                while (!validMove)
                {
                    char playerOneChoice = Console.ReadKey().KeyChar;
                    Console.WriteLine(' ');

                    // Makes sure their choice is an available option
                    if (int.TryParse(playerOneChoice.ToString(), out int playerOneChoiceInt) &&
                        playerOneChoiceInt >= 1 &&
                        playerOneChoiceInt <= 9)
                    {
                        int row = (playerOneChoiceInt - 1) / 3;
                        int col = (playerOneChoiceInt - 1) % 3;

                        if (board[row, col] != 'X' && board[row, col] != 'O')
                        {
                            board[row, col] = 'X';
                            validMove = true;
                        }
                        else
                        {
                            Console.WriteLine("This spot is already taken. Try again");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please choose an open spot number (1-9)");
                    }

                }

                // Call CheckWinner Method
                char result = gb.CheckWinner(board);
                
                // Checks results and ends game if someone won
                if (result == 'X')
                {
                    Console.WriteLine(' ');
                    Console.WriteLine("Player one won!");
                    gb.PrintBoard(board);
                    endGame = true;
                }
                else if (result == 'C')
                {
                    Console.WriteLine(' ');
                    Console.WriteLine("Game ended in a tie! Better luck next time!");
                    gb.PrintBoard(board);
                    endGame = true;
                }
                else
                {
                    Console.WriteLine("Good choice!");
                }
                playerone = false;
            }
            
            // Switches to player 2's turn and does the exact same thing as player 1's turn
            else
            {
                bool validMove = false;
                Console.WriteLine(' ');
                Console.WriteLine("Player two place an 'O' (e.g. 1)");
                
                // Call the print board method 
                gb.PrintBoard(board);
                while (!validMove)
                {
                    char playerTwoChoice = Console.ReadKey().KeyChar;
                    Console.WriteLine(' ');


                    // Checks for errors in the users answer
                    if (int.TryParse(playerTwoChoice.ToString(), out int playerTwoChoiceInt) &&
                        playerTwoChoiceInt >= 1 &&
                        playerTwoChoiceInt <= 9)
                    {
                        int row = (playerTwoChoiceInt - 1) / 3;
                        int col = (playerTwoChoiceInt - 1) % 3;

                        if (board[row, col] != 'X' && board[row, col] != 'O')
                        {
                            board[row, col] = 'O';
                            validMove = true;
                        }
                        else
                        {
                            Console.WriteLine("This spot is already taken");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please choose an open spot number (1-9)");
                    }
                }

                // Call CheckWinner Method
                char result = gb.CheckWinner(board);
                
                // Checks for results and ends game if someone won
                if (result == 'O')
                {
                    Console.WriteLine(' ');
                    Console.WriteLine("Player two won!");
                    gb.PrintBoard(board);
                    endGame = true;
                }
                else if (result == 'C')
                {
                    Console.WriteLine(' ');
                    Console.WriteLine("Game ended in a tie! Better luck next time!");
                    gb.PrintBoard(board);
                    endGame = true;
                }
                else
                {
                    Console.WriteLine("Good choice!");
                }
                playerone = true;
            }   
        }
    }
}



