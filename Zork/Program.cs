﻿using System;

namespace Zork
{
    class Program
    {
        //--------------------------//
        static void Main(string[] args)
        //--------------------------//
        {
            //Variables

            Console.WriteLine("Welcome to Zork!");

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


        }//END Main


    }//END Program

}//END Zork
