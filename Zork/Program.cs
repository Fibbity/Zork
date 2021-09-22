using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Zork
{

    //--------------------------//
    class Program
    //--------------------------//
    {
        private static readonly Room[,] rooms = {
            { new Room("Rocky Trail"),  new Room("South of House"), new Room("Canyon View") },
            { new Room("Forest"),       new Room("West of House"),  new Room("Behind House") },
            { new Room("Dense Woods"),  new Room("North of House"), new Room("Clearing") }
        }; //left is south, right is north, down is west, up is east

        private static (int row, int column) currentLocation = (1, 1);

        private static Room currentRoom
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
            InitializeRoomDescriptions();

            Room previousRoom = null;

            Console.WriteLine("Welcome to Zork!");

            Commands command = Commands.UNKNOWN;

            while (command != Commands.QUIT)
            {
                Console.WriteLine(currentRoom);

                if (previousRoom != currentRoom)
                {
                    Console.WriteLine(currentRoom.roomDescription);
                    previousRoom = currentRoom;
                }

                Console.Write("> ");
                command = ToCommand(Console.ReadLine().Trim());

                string outputString;
                switch (command)
                {
                    case Commands.LOOK:
                        command = Commands.LOOK;
                        outputString = $"{currentRoom.roomDescription}";
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

        //--------------------------//
        private static void InitializeRoomDescriptions()
        //--------------------------//
        {
            var roomMap = new Dictionary<string, Room>();
            foreach (Room room in rooms)
            {
                roomMap[room.roomName] = room;
            }

          roomMap["Rocky Trail"].roomDescription = "You are on a rock-strewn trail";
          roomMap["South of House"].roomDescription = "You are facing the south side of a white house. There is no door here, and all the windows are barred.";
          roomMap["Canyon View"].roomDescription = "You are at the top of the Great Canyon on its south wall.";
          roomMap["Forest"].roomDescription = "This is a forest, with trees in all directions around you.";
          roomMap["West of House"].roomDescription = "This is an open field west of a white house, with a boarded front door.";
          roomMap["Behind House"].roomDescription = "You are behind the white house. In one corner of the house there is a small window which is slightly ajar.";
          roomMap["Dense Woods"].roomDescription = "This is a dimly lit forest, with large trees all around. To the east, there appears to be sunlight.";
          roomMap["North of House"].roomDescription = "You are facing the north side of a white house. There is no door here, and all the windows are barred.";
          roomMap["Clearing"].roomDescription = "You are in a clearing, with a forest surrounding you on the west and south.";


        }//END InitializeRoomDescriptions

    }//END Program

}//END Zork
