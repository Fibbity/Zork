using System;

namespace Zork
{

    class Program
    {
        private static string[] rooms = new string[5] { "Forest", "West of House", "Behind House", "Clearing", "Canyon View" }; //left is west, right is east
        private static int currentRoom = 1;


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
                    case Commands.SOUTH:
                        outputString = "The way is shut!";
                        
                        break;

                    case Commands.EAST:
                        outputString = $"You moved {command}.";
                        currentRoom ++;
                        Console.WriteLine(rooms[currentRoom]);

                        if (currentRoom < 6)
                        {
                            currentRoom++;
                        }
                        else
                        {
                            outputString = "The way is shut!";
                            currentRoom = 5;
                        }

                        break;

                    case Commands.WEST:
                        outputString = $"You moved {command}.";
                        currentRoom --;
                        Console.WriteLine(rooms[currentRoom]);

                        if (currentRoom > -1)
                        {
                            currentRoom++;
                        }
                        else
                        {
                            outputString = "The way is shut!";
                            currentRoom = 0;
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
        private void Move()
        //--------------------------//
        {

        }//END Move

    }//END Program

}//END Zork
