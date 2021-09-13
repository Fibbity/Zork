using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Zork
{

    //--------------------------//
    public static class Assert
    //--------------------------//
    {
        [Conditional("DEBUG")]

        //--------------------------//
        public static void IsTrue(bool expression, string message = null)
        //--------------------------//
        {
            if (expression == false)
            {
                throw new Exception(message);
            }

        }//END IsTrue

    }//END Assert

    //--------------------------//
    class Program
    //--------------------------//
    {
        private static readonly string[,] rooms = {
            { "Rocky Trail", "South of House", "Canyon View" },
            { "Forest", "West of House", "Behind House" },
            { "Dense Woods", "North of House", "Clearing" }
        }; //left is south, right is north, down is west, up is east

        private static (int row, int column) currentLocation = (1, 1);

        private static string currentRoom
        {
            get
            {
                return rooms[currentLocation.row, currentLocation.column];
            }
        }

        private static bool IsDirection(Commands command) => Directions.Contains(command);

        private static readonly List<Commands> Directions = new List<Commands>
        {
            Commands.NORTH,
            Commands.SOUTH,
            Commands.EAST,
            Commands.WEST
        };

        #region Main

        //--------------------------//
        static void Main(string[] args)
        //--------------------------//
        {

            Console.WriteLine("Welcome to Zork!");

            Commands command = Commands.UNKNOWN;

            while (command != Commands.QUIT)
            {
                Console.WriteLine(currentRoom);
                Console.Write("> ");
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

                        outputString = $"You moved {command}.";

                        if (Move(command) == false)
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

        #endregion Main

        //--------------------------//
        private static Commands ToCommand(string commandString) => Enum.TryParse(commandString, true, out Commands result) ? result : Commands.UNKNOWN;
        //--------------------------//

        //--------------------------//
        private static bool Move(Commands command)
        //--------------------------//
        {
            Assert.IsTrue(IsDirection(command), "Invalid direction.");

            bool isValidMove = true;

            switch (command)
            {
                case Commands.NORTH when currentLocation.row < rooms.GetLength(0) - 1:
                    currentLocation.row++;
                    break;

                case Commands.SOUTH when currentLocation.row > 0:
                    currentLocation.row--;
                    break;

                case Commands.EAST when currentLocation.column < rooms.GetLength(1) - 1:
                    currentLocation.column++;
                    break;

                case Commands.WEST when currentLocation.column > 0:
                    currentLocation.column--;
                    break;

                default:
                    isValidMove = false;

                    break;
            }

            return isValidMove;

        }//END Move


    }//END Program

}//END Zork
