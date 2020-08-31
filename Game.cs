using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Game
    {

        string _playerName = "none";
        bool _gameOver = false;
        void OpenMainMenu()
        {
            char input = ' ';
            while(input != '1')
             RequestName();
        }

        void RequestName()
        {

            char input = ' ';
            Console.WriteLine("\nWhat is your name?");
            string _playerName = Console.ReadLine();
            Console.WriteLine("\nHello " + _playerName + "!");
            Console.WriteLine("Are you sure you want to keep this name:" + _playerName);
            input = GetInput("keep this name", "change this name");
            if (input == '2')
            {
                Console.WriteLine("I dont blame you for wanting to change that one.");
            }
        }
        void Explore()
        {
            char input = ' ';
            input = GetInput("Go Left", "Go Right", "You cam across a cross road");
                
        }

        char GetInput(string option1, string option2, qeury)
        {
            char input = ' ';
            while (input != '1' && input != '2')
            {

                Console.WriteLine(qeury);
                Console.WriteLine("\nPress 1 to " + option1);
                Console.WriteLine("Press 2 to " + option2);
                input = Console.ReadKey().KeyChar;
                Console.WriteLine();

            }
            return input;
        }
        //Run the game
        public void Run()
        {
            Start();

            while (_gameOver == false)
            {
                Update();
            }

            End();
        }

        //Performed once when the game begins
        public void Start()
        {
            Console.WriteLine("Welcome to the game!");
        }

        //Repeated until the game ends
        public void Update()
        {

            OpenMainMenu();
            Explore();

            Console.Clear();
            Console.WriteLine("Press 'q' to leave.");
            char input = ' ';
            input = Console.ReadKey().KeyChar;
            if (input == 'q')
            {
                _gameOver = true;
            }

        }

        //Performed once when the game ends
        public void End()
        {
            Console.WriteLine("\nThank you for playing my game!");
            Console.WriteLine("Press any key to exit out.");
        }
    }
}
