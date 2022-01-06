using ClassLibrary1;
using ClassLibrary1.ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramUI
{
    public class ProgramUI
    {
        public void RandomNumber()
        {
            int randomNumber;

            Random rdnm = new Random();
            randomNumber = rdnm.Next(1, 26);
        }

        private void GhostAttack()
        {
            {
                GhostAttack();
            }
            Ghost ghost = new Ghost();
            currentplayer.Health = currentplayer.Health - 1;
        }

        public static Ghost ghost = new Ghost();

        public static Player currentplayer = new Player();
        public void Run()
        {
            RunApp();
        }
        public void RunApp()
        {
            bool keepLooping = true;
            Player player = new Player();
            Console.WriteLine("Name Of Game");
            Console.WriteLine("Please enter your name.");
            currentplayer.Name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Before you is a decrepit house, its wooden exterior rotting and grass long dead. The biting wind chills you to the bone,\n" +
                "and you decide suspect shelter is better than none. You enter the house, its dark and forboding atmosphere making you second guess your\n" +
                "decison. Alarm bells ring in your mind, and you quickly turn on your heel to flee. Before you can return to the wilderness, however, the\n" +
                "front door slams in your face, and much to your dismay, the handle will not turn. It would appear you are stuck here... Resolved to find\n" +
                "a way out, you decide to explore this house. There are two rooms you can access from the main hall.");
            Console.ReadKey();
            while (keepLooping)
            {
                Console.WriteLine("Where will you go?\n" +
                    "1. Foyer\n" +
                    "2. Garden");
                int choiceOne = int.Parse(Console.ReadLine());
                if (choiceOne == 1)
                {
                    Foyer();
                }
                else if (choiceOne == 2)
                {
                    Garden();
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }

            }
        }
        static void Foyer()
        {
            bool glassCup = false;
            bool chainBroken = false;
            bool foyerKey = false;
            bool rugPulled = false;
            bool keepLooping = true;
            Console.Clear();
            Console.WriteLine("You enter the Foyer.");
            Console.WriteLine("You look around the Foyer. Up ahead are two winding staircases leading to the second floor, a set up against each wall.\n" +
                "On the ceiling is a looming chandelier hanging by a disturbingly feeble-looking chain. Beneath it is a worn rug, which you highly suspect\n" +
                "is infested with all manners of insects. At the back of the Foyer are two more doors, one leading to the living room, and another to the kitchen.");
            Console.ReadKey();
            if (keepLooping)
            {
                Console.WriteLine("What will you do?\n" +
                    "1. Inspect Room" +
                    "2. Go to Living Room\n" +
                    "3. Go to Kitchen\n" +
                    "4. Go to Front Yard\n" +
                    "5. Inspect chandelier\n" +
                    "6. Inspect rug\n");
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        if (chainBroken == false)
                        {
                            Console.WriteLine("You look around the Foyer. Up ahead are two winding staircases leading to the second floor, a set up against each wall.\n" +
                            "On the ceiling is a looming chandelier hanging by a disturbingly feeble-looking chain. Beneath it is a worn rug, which you highly suspect\n" +
                            "is infested with all manner of insects. At the back of the Foyer are two more doors, one leading to the living room, and another to the kitchen.");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("You look around the Foyer. Up ahead are two winding staircases leading to the second floor, a set up against each wall.\n" +
                            "In the center of the room lies the shattered chandelier. Beneath it is a worn rug, which you highly suspect is infested with all manner of insects.\n" +
                            "At the back of the Foyer are two more doors, one leading to the living room, and another to the kitchen.");
                            Console.ReadKey();
                        }
                        break;
                    case 2:
                        keepLooping = false;
                        LivingRoom();
                        break;
                    case 3:
                        keepLooping = false;
                        Kitchen();
                        break;
                    case 4:
                        keepLooping = false;
                        FrontYard();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("You inspect the chandelier. It is tilted heavily, and looks as if it may fall at any moment. Its chain looks extremely feeble.\n" +
                            "If something were to hit it, it may give out entirely...");
                        Console.ReadKey();
                        if (glassCup == true)
                        {
                            Console.WriteLine("Were you to throw the glass cup you picked up in the kitchen at the chain, it just might be enough to fell the chandelier.\n" +
                                "But why would you do that in the first place? Besides, you may need that cup later, and it's unlikely to survive the throw.\n" +
                                "Do you want to throw the cup at the chain? Enter Yes or No");
                            string chainChoice = Console.ReadLine();
                            if (chainChoice == "Yes")
                            {
                                glassCup = false;
                                foyerKey = true;
                                Console.WriteLine("Knowing you only have one shot at this, you aim carefully, and with a deep breath, throw the cup with all your might.\n" +
                                    "Against all odds, the glass connects with the chain, and the chandelier crashes into the ground! The chandelier explodes upon contact\n" +
                                    "the floor, and its debris is sent scattering across the room. A piece even strikes you with great force, but further inspection\n" +
                                    "reveals it to be no piece of the chandelier at all, but a key! What will it unlock, you wonder.");
                                Console.ReadKey();
                            }
                            else if (chainChoice == "No")
                            {
                                Console.WriteLine("You decide against throwing the cup, and continue on your way.");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please type Yes or No.");
                                Console.ReadKey();
                            }
                        }
                        break;
                    case 6:
                        Console.Clear();
                        if (rugPulled == false)
                        {
                            Console.WriteLine("There's always something hidden under the rug, right? You get on your hands and knees and pull up the corner of the rug.\n" +
                                "As you had feared, a torrent of insects come scurrying out from underneath, some even crawling up your legs! You desperately shake them\n" +
                                "off and fully pull back the rug, hoping your sacrifice was not in vain. Much to your dismay, it was, as there is nothing beneath except disappointment...");
                            Console.ReadKey();
                            rugPulled = true;
                        }
                        else
                        {
                            Console.WriteLine("You already inspected the rug.");
                            Console.ReadKey();
                        }
                        break;
                    default:
                        break;

                }
            }
        }
        static void Kitchen()
        {
            Console.Clear();
            Console.WriteLine("You enter the Kitchen.");
            Console.WriteLine("What will you do?\n" +
                "1. Inspect Room\n" +
                "2. Look Under Table\n" +
                "3. Look in Drawers\n" +
                "4. Look in Cabinets\n" +
                "5. Go to Foyer\n" +
                "6. Go to Wine Cellar");
            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    Console.WriteLine("You look around the Kitchen. In the center is an old wooden table");
                    break;
                case 2:
                    Console.WriteLine();
                    break;
                case 3:
                    Console.WriteLine();
                    break;
                case 4:
                    Console.WriteLine();
                    break;
                case 5:
                    Console.WriteLine();
                    break;
                case 6:
                    Console.WriteLine();
                    break;
                default:
                    break;
            }
        }
        static void Garden()
        {

        }
        static void LivingRoom()
        {

        }
        static void FrontYard()
        {

        }
    }
}

