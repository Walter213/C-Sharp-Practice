using System;

namespace CPSC1012_AP_Walter
{
    class Program
    {
        const int MAX_ROWS = 10;

        static void Main(string[] args)
        {
            string[] grid = new string[MAX_ROWS];
            int PlayerX = 0, PlayerO = 0, CellNumberX = 1, CellNumberY = 1, leave = 0;
            bool RightInput = true;
            bool PlayerTest = true;

            Console.WriteLine("********************");
            Console.WriteLine("* Tie-Tac-Toe Game *");
            Console.WriteLine("********************");
            Console.WriteLine("The cell numbers for the game is shown below");

            Console.WriteLine("-------------");
            Console.WriteLine("| 7 | 8 | 9 |");
            Console.WriteLine("-------------");
            Console.WriteLine("| 4 | 5 | 6 |");
            Console.WriteLine("-------------");
            Console.WriteLine("| 1 | 2 | 3 |");
            Console.WriteLine("-------------");

            while (RightInput == true)
            {
                if (CellNumberY < 6 && leave == 0)
                {
                    PlayerTest = true;
                }               

                while (PlayerTest == true)
                {
                    PlayerX = CheckForError("Enter cell number (1-9) for player X: ");

                    PlayerX--;

                    if (grid[PlayerX] == "X" || grid[PlayerX] == "O")
                    {
                        TakenGridSpot(grid, PlayerX, PlayerO);
                    }

                    else
                    {                       
                        PlayerX++;                        

                        SwitchXorO(grid, PlayerX, PlayerO);

                        ShowGrid(grid, PlayerX, PlayerO);

                        CellNumberX++;

                        PlayerTest = false;
                    }                   
                }                

                if (3 <= CellNumberX)
                {
                    if (grid[0] == "X")
                    {
                        if (grid[1] == "X")
                        {
                            if (grid[2] == "X")
                            {
                                Console.WriteLine("Player {0,1} wins!", "X");

                                Console.Write("Would you like to play again (y/n)? >> ");
                                char cInput = Convert.ToChar(Console.ReadLine());

                                if (cInput == 'n' || cInput == 'N')
                                {
                                    leave = 1;
                                    CellNumberX = 1;
                                    CellNumberY = 1;
                                    RightInput = false;
                                    Console.WriteLine("Good-bye and thanks for playing");
                                }

                                if (cInput == 'y' || cInput == 'Y')
                                {
                                    RightInput = true;
                                    grid = new string[MAX_ROWS];
                                    PlayerX = 0;
                                    PlayerO = 0;
                                    CellNumberX = 1;
                                    CellNumberY = 1;                                    
                                }
                            }
                        }
                    }

                    if (grid[3] == "X")
                    {
                        if (grid[4] == "X")
                        {
                            if (grid[5] == "X")
                            {
                                Console.WriteLine("Player {0,1} wins!", "X");

                                Console.Write("Would you like to play again (y/n)? >> ");
                                char cInput = Convert.ToChar(Console.ReadLine());

                                if (cInput == 'n' || cInput == 'N')
                                {
                                    leave = 1;
                                    CellNumberX = 1;
                                    CellNumberY = 1;
                                    RightInput = false;
                                    Console.WriteLine("Good-bye and thanks for playing");
                                }

                                if (cInput == 'y' || cInput == 'Y')
                                {
                                    RightInput = true;
                                    grid = new string[MAX_ROWS];
                                    PlayerX = 0;
                                    PlayerO = 0;
                                    CellNumberX = 1;
                                    CellNumberY = 1;
                                }
                            }                            
                        }
                    }

                    if (grid[6] == "X")
                    {
                        if (grid[7] == "X")
                        {
                            if (grid[8] == "X")
                            {
                                Console.WriteLine("Player {0,1} wins!", "X");

                                Console.Write("Would you like to play again (y/n)? >> ");
                                char cInput = Convert.ToChar(Console.ReadLine());

                                if (cInput == 'n' || cInput == 'N')
                                {
                                    leave = 1;
                                    CellNumberX = 1;
                                    CellNumberY = 1;
                                    RightInput = false;
                                    Console.WriteLine("Good-bye and thanks for playing");
                                }

                                if (cInput == 'y' || cInput == 'Y')
                                {
                                    RightInput = true;
                                    grid = new string[MAX_ROWS];
                                    PlayerX = 0;
                                    PlayerO = 0;
                                    CellNumberX = 1;
                                    CellNumberY = 1;
                                }
                            }
                        }
                    }

                    if (grid[0] == "X")
                    {
                        if (grid[3] == "X")
                        {
                            if (grid[6] == "X")
                            {
                                Console.WriteLine("Player {0,1} wins!", "X");

                                Console.Write("Would you like to play again (y/n)? >> ");
                                char cInput = Convert.ToChar(Console.ReadLine());

                                if (cInput == 'n' || cInput == 'N')
                                {
                                    leave = 1;
                                    CellNumberX = 1;
                                    CellNumberY = 1;
                                    RightInput = false;
                                    Console.WriteLine("Good-bye and thanks for playing");
                                }

                                if (cInput == 'y' || cInput == 'Y')
                                {
                                    RightInput = true;
                                    grid = new string[MAX_ROWS];
                                    PlayerX = 0;
                                    PlayerO = 0;
                                    CellNumberX = 1;
                                    CellNumberY = 1;
                                }
                            }
                        }
                    }

                    if (grid[1] == "X")
                    {
                        if (grid[4] == "X")
                        {
                            if (grid[7] == "X")
                            {
                                Console.WriteLine("Player {0,1} wins!", "X");

                                Console.Write("Would you like to play again (y/n)? >> ");
                                char cInput = Convert.ToChar(Console.ReadLine());

                                if (cInput == 'n' || cInput == 'N')
                                {
                                    leave = 1;
                                    CellNumberX = 1;
                                    CellNumberY = 1;
                                    RightInput = false;
                                    Console.WriteLine("Good-bye and thanks for playing");
                                }

                                if (cInput == 'y' || cInput == 'Y')
                                {
                                    RightInput = true;
                                    grid = new string[MAX_ROWS];
                                    PlayerX = 0;
                                    PlayerO = 0;
                                    CellNumberX = 1;
                                    CellNumberY = 1;
                                }
                            }
                        }
                    }

                    if (grid[2] == "X")
                    {
                        if (grid[5] == "X")
                        {
                            if (grid[8] == "X")
                            {
                                Console.WriteLine("Player {0,1} wins!", "X");

                                Console.Write("Would you like to play again (y/n)? >> ");
                                char cInput = Convert.ToChar(Console.ReadLine());

                                if (cInput == 'n' || cInput == 'N')
                                {
                                    leave = 1;
                                    CellNumberX = 1;
                                    CellNumberY = 1;
                                    RightInput = false;
                                    Console.WriteLine("Good-bye and thanks for playing");
                                }

                                if (cInput == 'y' || cInput == 'Y')
                                {
                                    RightInput = true;
                                    grid = new string[MAX_ROWS];
                                    PlayerX = 0;
                                    PlayerO = 0;
                                    CellNumberX = 1;
                                    CellNumberY = 1;
                                }
                            }
                        }
                    }

                    if (grid[0] == "X")
                    {
                        if (grid[4] == "X")
                        {
                            if (grid[8] == "X")
                            {
                                Console.WriteLine("Player {0,1} wins!", "X");

                                Console.Write("Would you like to play again (y/n)? >> ");
                                char cInput = Convert.ToChar(Console.ReadLine());

                                if (cInput == 'n' || cInput == 'N')
                                {
                                    leave = 1;
                                    CellNumberX = 1;
                                    CellNumberY = 1;
                                    RightInput = false;
                                    Console.WriteLine("Good-bye and thanks for playing");
                                }

                                if (cInput == 'y' || cInput == 'Y')
                                {
                                    RightInput = true;
                                    grid = new string[MAX_ROWS];
                                    PlayerX = 0;
                                    PlayerO = 0;
                                    CellNumberX = 1;
                                    CellNumberY = 1;
                                }
                            }
                        }
                    }

                    if (grid[2] == "X")
                    {
                        if (grid[4] == "X")
                        {
                            if (grid[6] == "X")
                            {
                                Console.WriteLine("Player {0,1} wins!", "X");

                                Console.Write("Would you like to play again (y/n)? >> ");
                                char cInput = Convert.ToChar(Console.ReadLine());

                                if (cInput == 'n' || cInput == 'N')
                                {
                                    leave = 1;
                                    CellNumberX = 1;
                                    CellNumberY = 1;
                                    RightInput = false;
                                    Console.WriteLine("Good-bye and thanks for playing");
                                }

                                if (cInput == 'y' || cInput == 'Y')
                                {
                                    RightInput = true;
                                    grid = new string[MAX_ROWS];
                                    PlayerX = 0;
                                    PlayerO = 0;
                                    CellNumberX = 1;
                                    CellNumberY = 1;
                                }
                            }
                        }
                    }

                    if (CellNumberX == 6)
                    {
                        Console.WriteLine("Its a draw, Nobody Wins!!");

                        Console.Write("Would you like to play again (y/n)? >> ");
                        char cInput = Convert.ToChar(Console.ReadLine());

                        if (cInput == 'n' || cInput == 'N')
                        {                           
                            leave = 1;
                            CellNumberX = 1;
                            CellNumberY = 1;
                            RightInput = false;
                            Console.WriteLine("Good-bye and thanks for playing");
                        }

                        if (cInput == 'y' || cInput == 'Y')
                        {
                            RightInput = true;
                            grid = new string[MAX_ROWS];
                            PlayerX = 0;
                            PlayerO = 0;
                            CellNumberX = 1;
                            CellNumberY = 1;
                        }
                    }
                }

                if (CellNumberX < 6 && leave == 0)
                {
                    PlayerTest = true;
                }

                while (PlayerTest == true)
                {
                    PlayerO = CheckForError("Enter cell number (1-9) for player O: ");

                    PlayerO--;

                    if (grid[PlayerO] == "X" || grid[PlayerO] == "O")
                    {
                        TakenGridSpot(grid, PlayerX, PlayerO);
                    }

                    else
                    {
                        PlayerO++;

                        SwitchXorO(grid, PlayerX, PlayerO);

                        ShowGrid(grid, PlayerX, PlayerO);

                        CellNumberY++;

                        PlayerTest = false;
                    }                  
                }

                if (3 <= CellNumberX)
                {
                    if (grid[0] == "O")
                    {
                        if (grid[1] == "O")
                        {
                            if (grid[2] == "O")
                            {
                                Console.WriteLine("Player {0,1} wins!", "O");

                                Console.Write("Would you like to play again (y/n)? >> ");
                                char cInput = Convert.ToChar(Console.ReadLine());

                                if (cInput == 'n' || cInput == 'N')
                                {
                                    leave = 1;
                                    CellNumberX = 1;
                                    CellNumberY = 1;
                                    RightInput = false;
                                    Console.WriteLine("Good-bye and thanks for playing");
                                }

                                if (cInput == 'y' || cInput == 'Y')
                                {
                                    RightInput = true;
                                    grid = new string[MAX_ROWS];
                                    PlayerX = 0;
                                    PlayerO = 0;
                                    CellNumberX = 1;
                                    CellNumberY = 1;
                                }
                            }
                        }
                    }

                    if (grid[3] == "O")
                    {
                        if (grid[4] == "O")
                        {
                            if (grid[5] == "O")
                            {
                                Console.WriteLine("Player {0,1} wins!", "O");

                                Console.Write("Would you like to play again (y/n)? >> ");
                                char cInput = Convert.ToChar(Console.ReadLine());

                                if (cInput == 'n' || cInput == 'N')
                                {
                                    leave = 1;
                                    CellNumberX = 1;
                                    CellNumberY = 1;
                                    RightInput = false;
                                    Console.WriteLine("Good-bye and thanks for playing");
                                }

                                if (cInput == 'y' || cInput == 'Y')
                                {
                                    RightInput = true;
                                    grid = new string[MAX_ROWS];
                                    PlayerX = 0;
                                    PlayerO = 0;
                                    CellNumberX = 1;
                                    CellNumberY = 1;
                                }
                            }
                        }
                    }

                    if (grid[6] == "O")
                    {
                        if (grid[7] == "O")
                        {
                            if (grid[8] == "O")
                            {
                                Console.WriteLine("Player {0,1} wins!", "O");

                                Console.Write("Would you like to play again (y/n)? >> ");
                                char cInput = Convert.ToChar(Console.ReadLine());

                                if (cInput == 'n' || cInput == 'N')
                                {
                                    leave = 1;
                                    CellNumberX = 1;
                                    CellNumberY = 1;
                                    RightInput = false;
                                    Console.WriteLine("Good-bye and thanks for playing");
                                }

                                if (cInput == 'y' || cInput == 'Y')
                                {
                                    RightInput = true;
                                    grid = new string[MAX_ROWS];
                                    PlayerX = 0;
                                    PlayerO = 0;
                                    CellNumberX = 1;
                                    CellNumberY = 1;
                                }
                            }
                        }
                    }

                    if (grid[0] == "O")
                    {
                        if (grid[3] == "O")
                        {
                            if (grid[6] == "O")
                            {
                                Console.WriteLine("Player {0,1} wins!", "O");

                                Console.Write("Would you like to play again (y/n)? >> ");
                                char cInput = Convert.ToChar(Console.ReadLine());

                                if (cInput == 'n' || cInput == 'N')
                                {
                                    leave = 1;
                                    CellNumberX = 1;
                                    CellNumberY = 1;
                                    RightInput = false;
                                    Console.WriteLine("Good-bye and thanks for playing");
                                }

                                if (cInput == 'y' || cInput == 'Y')
                                {
                                    RightInput = true;
                                    grid = new string[MAX_ROWS];
                                    PlayerX = 0;
                                    PlayerO = 0;
                                    CellNumberX = 1;
                                    CellNumberY = 1;
                                }
                            }
                        }
                    }

                    if (grid[1] == "O")
                    {
                        if (grid[4] == "O")
                        {
                            if (grid[7] == "O")
                            {
                                Console.WriteLine("Player {0,1} wins!", "O");

                                Console.Write("Would you like to play again (y/n)? >> ");
                                char cInput = Convert.ToChar(Console.ReadLine());

                                if (cInput == 'n' || cInput == 'N')
                                {
                                    leave = 1;
                                    CellNumberX = 1;
                                    CellNumberY = 1;
                                    RightInput = false;
                                    Console.WriteLine("Good-bye and thanks for playing");
                                }

                                if (cInput == 'y' || cInput == 'Y')
                                {
                                    RightInput = true;
                                    grid = new string[MAX_ROWS];
                                    PlayerX = 0;
                                    PlayerO = 0;
                                    CellNumberX = 1;
                                    CellNumberY = 1;
                                }
                            }
                        }
                    }

                    if (grid[2] == "O")
                    {
                        if (grid[5] == "O")
                        {
                            if (grid[8] == "O")
                            {
                                Console.WriteLine("Player {0,1} wins!", "O");

                                Console.Write("Would you like to play again (y/n)? >> ");
                                char cInput = Convert.ToChar(Console.ReadLine());

                                if (cInput == 'n' || cInput == 'N')
                                {
                                    leave = 1;
                                    CellNumberX = 1;
                                    CellNumberY = 1;
                                    RightInput = false;
                                    Console.WriteLine("Good-bye and thanks for playing");
                                }

                                if (cInput == 'y' || cInput == 'Y')
                                {
                                    RightInput = true;
                                    grid = new string[MAX_ROWS];
                                    PlayerX = 0;
                                    PlayerO = 0;
                                    CellNumberX = 1;
                                    CellNumberY = 1;
                                }
                            }
                        }
                    }

                    if (grid[0] == "O")
                    {
                        if (grid[4] == "O")
                        {
                            if (grid[8] == "O")
                            {
                                Console.WriteLine("Player {0,1} wins!", "O");

                                Console.Write("Would you like to play again (y/n)? >> ");
                                char cInput = Convert.ToChar(Console.ReadLine());

                                if (cInput == 'n' || cInput == 'N')
                                {
                                    leave = 1;
                                    CellNumberX = 1;
                                    CellNumberY = 1;
                                    RightInput = false;
                                    Console.WriteLine("Good-bye and thanks for playing");
                                }

                                if (cInput == 'y' || cInput == 'Y')
                                {
                                    RightInput = true;
                                    grid = new string[MAX_ROWS];
                                    PlayerX = 0;
                                    PlayerO = 0;
                                    CellNumberX = 1;
                                    CellNumberY = 1;
                                }
                            }
                        }
                    }

                    if (grid[2] == "O")
                    {
                        if (grid[4] == "O")
                        {
                            if (grid[6] == "O")
                            {
                                Console.WriteLine("Player {0,1} wins!", "O");

                                Console.Write("Would you like to play again (y/n)? >> ");
                                char cInput = Convert.ToChar(Console.ReadLine());

                                if (cInput == 'n' || cInput == 'N')
                                {
                                    leave = 1;
                                    CellNumberX = 1;
                                    CellNumberY = 1;
                                    RightInput = false; 
                                    Console.WriteLine("Good-bye and thanks for playing");
                                }

                                if (cInput == 'y' || cInput == 'Y')
                                {
                                    RightInput = true;
                                    grid = new string[MAX_ROWS];
                                    PlayerX = 0;
                                    PlayerO = 0;
                                    CellNumberX = 1;
                                    CellNumberY = 1;
                                }
                            }
                        }
                    }

                    if (CellNumberY == 6)
                    {
                        Console.WriteLine("Its a draw, Nobody Wins!!");

                        Console.Write("Would you like to play again (y/n)? >> ");
                        char cInput = Convert.ToChar(Console.ReadLine());

                        if (cInput == 'n' || cInput == 'N')
                        {
                            leave = 1;
                            RightInput = false;
                            Console.WriteLine("Good-bye and thanks for playing");
                        }

                        if (cInput == 'y' || cInput == 'Y')
                        {
                            RightInput = true;
                            grid = new string[MAX_ROWS];
                            PlayerX = 0;
                            PlayerO = 0;
                            CellNumberX = 0;
                            CellNumberY = 0;
                        }
                    }
                }
            }           
        }

        static void SwitchXorO(string[] grid, int PlayerX, int PlayerO)
        {
            bool Switching = true;

            while (Switching == true)
            {
                if (PlayerX > 0)
                {
                    PlayerX--;
                    grid[PlayerX] = "X";
                    Switching = false;
                }

                if (PlayerO > 0)
                {
                    PlayerO--;
                    grid[PlayerO] = "O";
                    Switching = false;
                }               
            }        
        }

        static void ShowGrid(string[] grid, int PlayerX, int PlayerO)
        {
            Console.WriteLine("-------------");
            Console.WriteLine("| {0,1} | {1,1} | {2,1} |", grid[6], grid[7], grid[8]);
            Console.WriteLine("-------------");
            Console.WriteLine("| {0,1} | {1,1} | {2,1} |", grid[3], grid[4], grid[5]);
            Console.WriteLine("-------------");
            Console.WriteLine("| {0,1} | {1,1} | {2,1} |", grid[0], grid[1], grid[2]);
            Console.WriteLine("-------------");
        }

        static int CheckForError(string prompt)
        {
            int message = 0;
            bool RightW = true;

            while (RightW == true)
            {
                try
                {
                    Console.Write(prompt);
                    message = Convert.ToInt32(Console.ReadLine());

                    if (message > 9 || message < 1)
                    {
                        Console.WriteLine("Enter In a valid cell number");

                        bool WrongInput = true;

                        while (WrongInput == true)
                        {
                            Console.Write(prompt);
                            message = Convert.ToInt32(Console.ReadLine());

                            if (message > 9 || message < 1)
                            {
                                Console.WriteLine("Enter In a valid cell number");
                            }
                            if (message >= 1 && message <= 9)
                            {
                                WrongInput = false;                            
                            }
                        }
                    }
                    RightW = false;
                }

                catch
                {
                    Console.WriteLine("Please Enter in a valid cell number");
                }
            }
            return message;
        }
        
        static int TakenGridSpot(string[] grid, int PlayerX, int PlayerO)
        {
            int message = 0;
            bool RightW = true;

            while (RightW == true)
            {
                if (grid[PlayerO] == "X")
                {
                    Console.WriteLine("This Spot is already taken up, please choose a spot that is avaliable on the board");
                    RightW = false;
                }

                if (grid[PlayerX] == "O")
                {
                    Console.WriteLine("This Spot is already taken up, please choose a spot that is avaliable on the board");
                    RightW = false;
                }                

                RightW = false;

            }

            return message;
        }
    }
}