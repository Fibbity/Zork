using System;

namespace Zork
{

    //--------------------------//
    class Program
    //--------------------------//
    {

        //--------------------------//
        static void Main(string[] args)
        //--------------------------//
        {
            const string defaultGameFilename = "Zork.json";
            string gameFilename = args.Length > 0 ? args[(int)CommandLineArguments.GameFilename] : defaultGameFilename;

            ConsoleOutputService output = new ConsoleOutputService();
            Game game = Game.Load(gameFilename, output);
            game.Run();

        }//END Main

        private enum CommandLineArguments
        {
            GameFilename = 0
        }

    }//END Program

}//END Zork
