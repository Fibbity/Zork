using System;

namespace Zork
{

    class Program
    {
        private static readonly string[,] rooms = {
            { "Rocky Trail", "South of House", "Canyon View" },
            { "Forest", "West of House", "Behind House" },
            { "Dense Woods", "North of House", "Clearing" }
        }; //left is west, right is east, up is north, down is south

        private static (int row, int column) location = (1, 1);
        private static string currentRoom
        {
            get
            {
                return rooms[location.row, location.column];
            }
        }
        private static int lastRoom = rooms.Length - 1;
        private static bool isMoving;


        //--------------------------//
        static void Main(string[] args)
        //--------------------------//
        {
            Console.WriteLine("Welcome to Zork!");

            Commands command = Commands.UNKNOWN;

            while (command != Commands.QUIT)
            {
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

                        Move(command);

                        if (isMoving == true)
                        {
                            currentRoom;//TODO change later
                            outputString = $"You moved {command}.";
                            Console.WriteLine(rooms[currentRoom]);
                        }
                        else
                        {
                            outputString = "The way is shut!";
                        }

                        break;

                    case Commands.SOUTH:

                        Move(command);

                        if (isMoving == true)
                        {
                            currentRoom--;//TODO change later

                            outputString = $"You moved {command}.";
                            Console.WriteLine(rooms[currentRoom]);
                        }
                        else
                        {
                            outputString = "The way is shut!";
                        }

                        break;
                        
                    case Commands.EAST:

                        Move(command);

                        if (isMoving == true)
                        {
                            currentRoom++;

                            outputString = $"You moved {command}.";
                            Console.WriteLine(rooms[currentRoom]);
                        }
                        else
                        {
                            outputString = "The way is shut!";
                        }

                        break;

                    case Commands.WEST:

                        Move(command);

                        if (isMoving == true)
                        {
                            currentRoom--;

                            outputString = $"You moved {command}.";
                            Console.WriteLine(rooms[currentRoom]);
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

                    isMoving = false; //TODO Refactor

                    break;

                case Commands.SOUTH:

                    isMoving = false; //TODO Refactor

                    break;

                case Commands.EAST:

                    if(currentRoom < lastRoom)
                    {
                        isMoving = true;
                    }
                    else
                    {
                        isMoving = false;
                    }

                    break;

                case Commands.WEST:

                    if (currentRoom > 0)
                    {
                        isMoving = true;
                    }
                    else
                    {
                        isMoving = false;
                    }

                    break;

                default:
                    System.Diagnostics.Debug.WriteLine("Not a direction!");

                    isMoving = false;

                    break;
            }


        }//END Move

    }//END Program

}//END Zork
