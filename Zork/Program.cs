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

                string outputString = null; //Do I really need to make this null?
                switch (command)
                {
                    case Commands.LOOK:
                        command = Commands.LOOK;
                        Console.WriteLine("A rubber mat saying 'Welcome to Zork!' lies by the door.");

                        //outputString = "A rubber mat saying 'Welcome to Zork!' lies by the door."; //Is this what's desired?

                        break;

                    case Commands.NORTH:
                        command = Commands.NORTH;
                        Console.WriteLine("You moved NORTH");

                        break;

                    case Commands.EAST:
                        command = Commands.EAST;
                        Console.WriteLine("You moved EAST");

                        break;

                    case Commands.SOUTH:
                        command = Commands.SOUTH;
                        Console.WriteLine("You moved SOUTH");

                        break;

                    case Commands.WEST:
                        command = Commands.WEST;
                        Console.WriteLine("You moved WEST");

                        break;

                    case Commands.QUIT:
                        command = Commands.QUIT;
                        Console.WriteLine("Thank you for playing!");

                        break;

                    default:
                        command = Commands.UNKNOWN;
                        Console.WriteLine("Unrecognized Command");

                        break;

                }

                Console.WriteLine(outputString);

            }

            /*
            string inputString = Console.ReadLine(); //Also establishes inputString variable


            inputString = inputString.ToUpper();
            if (inputString == "QUIT")
            {
                Console.WriteLine("Thank you for playing.");

            }
            else if (inputString == "LOOK")
            {
                Console.WriteLine("This is an open field West of a white house, with a boarded front door. \nA rubber mat saying 'Welcome to Zork' lies by the door.");

            }
            else
            {
                Console.WriteLine("Unrecognized command.");

            }
            */

        }//END Main

        //--------------------------//
        private static Commands ToCommand(string commandString) => Enum.TryParse(commandString, true, out Commands result) ? result : Commands.UNKNOWN;
        //--------------------------//


    }//END Program

}//END Zork
