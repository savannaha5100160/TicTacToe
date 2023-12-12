using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using TicTacToeRendererLib.Enums;
using TicTacToeRendererLib.Renderer;

namespace TicTacToeSubmissionConole
{
    public class TicTacToe
    {
        private TicTacToeConsoleRenderer _boardRenderer;

        public TicTacToe()
        {
            _boardRenderer = new TicTacToeConsoleRenderer(10, 6);
            _boardRenderer.Render();
        }


        public void Run()
        { bool game

            // FOR ILLUSTRATION CHANGE TO YOUR OWN LOGIC TO DO TIC TAC TOE

                while(!gamecomplete)

            Console.SetCursorPosition(2, 19);

            Console.Write("Player X");

            Console.SetCursorPosition(2, 20);

            Console.Write("Please Enter Row: ");
            var row = Console.ReadLine();

            Console.SetCursorPosition(2, 22);


            Console.Write("Please Enter Column: ");
            var column = Console.ReadLine();

            // THIS JUST DRAWS THE BOARD (NO TIC TAC TOE LOGIC)
            _boardRenderer.AddMove(int.Parse(row), int.Parse(column), PlayerEnum.X, true);

            Console.SetCursorPosition(2, 19);

            Console.Write("Player O");

            Console.SetCursorPosition(2, 20);

            Console.Write("Please Enter Row: ");
            var row = Console.ReadLine();

            Console.SetCursorPosition(2, 22);


            Console.Write("Please Enter Column: ");
            var column = Console.ReadLine();


            // THIS JUST DRAWS THE BOARD (NO TIC TAC TOE LOGIC)
            _boardRenderer.AddMove(int.Parse(row), int.Parse(column), PlayerEnum.0, true);

            private bool CheckForWin(int row, int column)
            {
                char currentPlayer = _boardRenderer.AddMove(row, column, PlayerEnum.X, false) ? 'X' : 'O;

                    //Checkfor a win in the row
                    if (CheckWinInLine(0, 0, 0, 1, 0, 2, currentPlayer)or
                        CheckWinInLine(1, 0, 1, 1, 1, 2, currentPlayer)or
                    CheckWinInLine(2, 0, 2, 1, 2, 2, currentPlayer))
                    {
                    return true;
                }
                //Check for a win in the column
                if (CheckWinInLine(0, 0, 1, 0, 2, 0, currentPlayer)or
                        CheckWinInLine(0, 1, 1, 1, 2, 1, currentPlayer)or
                    CheckWinInLine(0, 2, 1, 2, 2, 2, currentPlayer))
                    { return true; }

                //Check for a win in the main diagonal
                if (CheckWinInLine(0, 0, 1, 1, 2, 2, currentPlayer))
                {
                    return true;
                }

                //Check for a win in the second diagonal
                if (CheckWinInLine(0, 2, 1, 1, 2, 0, currentPlayer))
                { return true;
                }
            }
            return false;
        }
        private bool CheckWinInLine(int row 1, int column 1, int row 2, int column 2, int row 3, int column 3, char player)
        {
            return _boardRenderer.AddMove(row, column 1, player, false) &&
                _boardRenderer.AddMove(row 2, column 2, player, false) &&
                _boardRenderer.AddMove(row 3, column 3, player, false);
        }

    }
}
