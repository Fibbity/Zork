using System;

namespace Zork
{

    class Program
    {
        private static readonly string[,] rooms = {
            { "Rocky Trail", "South of House", "Canyon View" },
            { "Forest", "West of House", "Behind House" },
            { "Dense Woods", "North of House", "Clearing" }
        }; //left is south, right is north, down is west, up is east
        private static (int row, int column) currentLocation = (1, 1);
        private static bool isMoving;


        //--------------------------//
        static void Main(string[] args)
        //--------------------------//
        {

            Console.WriteLine("Welcome to Zork!");

            Commands command = Commands.UNKNOWN;

            while (command != Commands.QUIT)
            {
                Console.Write($"{ rooms[currentLocation.row, currentLocation.column]}\n> ");
                command = ToCommand(Console.ReadLine().Trim());

                string outputString;
                switch (command)
                {
                    case Commands.LOOK:
                        command = Commands.LOOK;
                        outputString = "A rubber mat saying 'Welcome to Zork!' lies by the door.";

                        break;

                    case Commands.NORTH:
                    case Commands.SOUTH:                        
                    case Commands.EAST:
                    case Commands.WEST:

                        Move(command);

                        if (isMoving == true)
                        {
                            outputString = $"You moved {command}.";
                        }
                        else
                        {
                            outputString = "The way is shut!";

                        }
                        

                        break;

                    case Commands.QUIT:
                        outputString = "Thank you for playing!";

                        break;

                    default:
                        outputString = "Unrecognized Command";

                        break;

                }

                Console.WriteLine(outputString);

            }

        }//END Main

        //--------------------------//
        private static Commands ToCommand(string commandString) => Enum.TryParse(commandString, true, out Commands result) ? result : Commands.UNKNOWN;
        //--------------------------//

        //--------------------------//
        private static void Move(Commands inputCommand)
        //--------------------------//
        {
            switch (inputCommand)
            {
                case Commands.NORTH:

                    if (currentLocation.row < rooms.GetLength(0) - 1)
                    {
                        isMoving = true;
                        currentLocation.row++;
                    }
                    else
                    {
                        isMoving = false;
                    }

                    break;

                case Commands.SOUTH:

                    if (currentLocation.row > 0)
                    {
                        isMoving = true;
                        currentLocation.row--;
                    }
                    else
                    {
                        isMoving = false;
                    }

                    break;

                case Commands.EAST:

                    if (currentLocation.column < rooms.GetLength(1) - 1)
                    {
                        isMoving = true;
                        currentLocation.column++;
                    }
                    else
                    {
                        isMoving = false;
                    }

                    break;

                case Commands.WEST:

                    if (currentLocation.column > 0)
                    {
                        isMoving = true;
                        currentLocation.column--;
                    }
                    else
                    {
                        isMoving = false;
                    }

                    break;

                default:
                    isMoving = false;

                    break;
            }


        }//END Move

    }//END Program

}//END Zork
