using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ProgramUI
    {
        public void RandomNumber()
        {
            int randomNumber;

        Random rdnm = new Random();
        randomNumber = rdnm.Next(1 , 26);
        }
        

        public void Run()
        {
            RunApp();
        }
        public void RunApp()
        {
            Player player = new Player();
            bool glassCup = false;
            Console.WriteLine("Name Of Game");
            Console.WriteLine("Please enter your name.");
            player.Name = Console.ReadLine();

            Console.WriteLine("Before you is a decrepit house, its wooden exterior rotting and grass long dead. The biting wind chills you to the bone, and you decide suspect" +
                "shelter is better than none.You enter the house, its dark and forboding atmosphere making you second guess your decison.Alarm bells ring in your mind, and you " +
                "quickly turn on your heel to flee. Before you can return to the wilderness, however, the front door slams in your face, and much to your dismay, the handle will " +
                "not turn. It would appear you are stuck here... Resolved to find a way out, you decide to explore this house. There are two rooms you can access from the main hall.");
            Console.WriteLine("Where will you go?\n" +
                "1. Foyer\n" +
                "2. Garden");
            int choiceOne = int.Parse(Console.ReadLine());
            if (choiceOne == 1)
            {
                Console.WriteLine("You look around the Foyer. Up ahread are two winding staircases leading to the second floor, a set up against each wall. On the ceiling is a looming" +
                    "chandelier hanging by a disturbingly feeble-looking chain. Beneath it is a worn rug, which you highly suspect is infested with all manners of insects." +
                    "At the back of the Foyer are two more doors, one leading to the living room, and another to the kitchen.");
                Console.WriteLine("What will you do?\n" +
                    "1. Go to Living Room\n" +
                    "2. Go to Kitchen\n" +
                    "3. Inspect chandelier\n" +
                    "4. Inspect rug\n" +
                    "5. Inspect room");
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.WriteLine("You inspect the chandelier. It is tilted heavily, and looks as if it may fall at any moment. Its chain looks extremely feeble.\n" +
                            "If something were to hit it, it may give out entirely...");
                        if (glassCup == true)
                        {
                            Console.WriteLine("");
                        }
                        break;
                    case 4:
                        Console.WriteLine();
                        break;
                    case 5:
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine("");
                        break;
                }

            }

        }
    }
}

