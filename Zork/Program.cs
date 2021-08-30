using System;

namespace Zork
{

    enum Commands
    {
        QUIT,
        LOOK,
        NORTH,
        EAST,
        SOUTH,
        WEST,
        UNKNOWN
    }

    class Program
    {
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
                    case Commands.EAST:
                    case Commands.SOUTH:
                    case Commands.WEST:
                        outputString = "You moved " + command;

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


    }//END Program

}//END Zork
