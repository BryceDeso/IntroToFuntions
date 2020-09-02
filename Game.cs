using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Game
    {

        string _playerName = "the player";
        int playerHealth = 100;
        bool _gameOver = false; 

        //This is used to request a name.
        void RequestName(ref string name)
        {

            char input = ' ';
            
            Console.WriteLine("Please enter a new name for " + name);
            name = Console.ReadLine();
            input = GetInput("keep this name", "change this name", "Are you sure you want to keep the name: " + name);
            if (input == '1')
            {
                return;
            }
            else if(input == '2')
            {
                Console.WriteLine("I dont blame you for wanting to change that one.");
                RequestName(ref name);
            }
            

        }

        //This will get input from the player.
        char GetInput(string option1, string option2, string query)
        {
            char input = ' ';
            while (input != '1' && input != '2')
            {
                Console.WriteLine(query);
                Console.WriteLine("\nPress 1 to " + option1);
                Console.WriteLine("Press 2 to " + option2);;
                input = Console.ReadKey().KeyChar;
                Console.WriteLine();

            }
            return input;
        }

        //This is where the player will explore the game.
        void Explore()
        {
            //This gives the player an option to go left or right down the path.
            Console.WriteLine("You begin your adventure and begin to head down a path.");
            char input = ' ';
            string petName = "mini dragon";
            input = GetInput("Go Left", "Go Right", "You come across a cross road");
            if (input == '1')
            {
                Console.WriteLine("You go left an meet a group of bandits and before you are attacked a mini dragon swoops in and charrs some of the the bandits.");
                Console.WriteLine("The mini drgaon lands next to you and you decide to keep it. What should you name it?");
                RequestName(ref petName);
                Console.WriteLine("New name is " + petName);
                Console.ReadKey();
            }
            else if (input == '2')
            {
                Console.WriteLine("You head down the path towards ohio.");
                Console.ReadKey();
            }
            Console.Clear();
            Console.WriteLine("As you begin to admire you new companion a single bandit rushes you!");
            Console.WriteLine("Start fight encounter");
            int enemyHealth = 75;
            _gameOver = StartBattle(ref playerHealth);


        }

        void EnterRoom(int roomNumber)
        {
            string exitMessgae = "";
            switch (roomNumber)
            {

                case 0:
                    {
                        Console.WriteLine("You are at the entrence of a small wooden shack...");
                        break;
                    }
                case 1:
                case 2:
                    {
                        Console.WriteLine("You enter the shack.");
                        Console.WriteLine("The shack is illuminated by a single dull lightbulb.");
                        Console.WriteLine("You look forward and see a door identical to the one you just walked thorugh.");
                        Console.WriteLine("You look back and see the door you entered still there.");
                        break;
                    }

                default:
                    {
                        Console.WriteLine("You enter a room identical to the first room.");
                        break;
                    }

            }
            
            if(roomNumber == 0)
            {
                Console.WriteLine("You are at the entrence of a small wooden shack...");
            }
            else if (roomNumber == 1)
            {

            }
            else if (roomNumber == 2)
            {
                Console.WriteLine("You enter an identcal.");
                Console.WriteLine(".");
                Console.WriteLine("");
            }
            else if (roomNumber == 23)
            {
                Console.WriteLine("Something is kinda off...");
            }
            Console.WriteLine("You are in room " + roomNumber);
            char input = ' ';
            input = GetInput("Go Foward", "Go Back", "Which direction would you like to go?");
            if (input == '1')
            {
                EnterRoom(roomNumber + 1);
            }
            Console.WriteLine("You are leaveing room " + roomNumber);
        }
        

        //This is used for nay fighting that the player does.
        bool StartBattle(ref int charcterHealth, int character2Health = 100)
        {

            char input = ' ';
            while(charcterHealth > 0 && character2Health > 0)
            {
                //get input from player
                input = GetInput("Attack", "Defend", "\nWhat will you do?");
                //If input is 1 the player attacks the enemy
                if(input == '1')
                {
                    character2Health -= 10;
                    Console.WriteLine("You attack and did 10 damage");
                }
                //If the input is 2 the player blockes the enemy
                else if(input == '2')
                {
                    Console.WriteLine("You blocked the enemy's attack!");
                    Console.ReadKey();
                    continue;
                }
                charcterHealth -= 20;
                Console.WriteLine("The enemy attacked and did 20 damage!");
                Console.ReadKey();
                Console.Clear();
            }
            return charcterHealth < 0;
        }

        //This will display player stats.
        void ViewStats()
        {

            Console.WriteLine(_playerName);
            Console.WriteLine(playerHealth);

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
            //RequestName(ref _playerName);
            EnterRoom(0);

        }

        //Performed once when the game ends
        public void End()
        {
            Console.WriteLine("\nThank you for playing my game!");
            Console.WriteLine("Press any key to exit out.");
        }

    } 
}
