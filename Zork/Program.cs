using System;

namespace Zork
{

    class Program
    {
        private static string[] rooms = new string[5] { "Forest", "West of House", "Behind House", "Clearing", "Canyon View" }; //left is west, right is east
        private static int currentRoom = 1;
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
                            currentRoom++;//TODO change later
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
                    Console.WriteLine("That's not right.");
                    break;
            }


        }//END Move

    }//END Program

}//END Zork
