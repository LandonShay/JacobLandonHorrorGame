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
        static bool glassCup = false;
        static bool glassUsed = false;
        static bool chainBroken = false;
        static bool foyerKey = false;
        static bool rugPulled = false;
        static bool attackedByBat = false;
        static bool HasShovel = false;
        static bool gardenRing = false;
        static bool ghostSkull = false;
        static bool ghostBones = false;
        static bool lighter = false;
        static Player player = new Player();
        public static void GhostAttack()
        {
            Random rdnm = new Random();
            int randomNumber = rdnm.Next(1, 26);
            if (randomNumber >= 23)
            {
                Ghost ghost = new Ghost();
                player.Health = player.Health - 1;
                if (player.Health == 0)
                {
                    //end game
                }
            }
        }


        public void Run()
        {
            RunApp();
        }
        public void RunApp()
        {
            bool keepLooping = true;
            Console.WriteLine("The Haunting of Jacob Landon");
            Console.WriteLine("Please enter your name.");
            player.Name = Console.ReadLine();
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
                    keepLooping = false;
                    Foyer();
                }
                else if (choiceOne == 2)
                {
                    keepLooping = false;
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
            GhostAttack();
            bool keepLooping = true;
            Console.Clear();
            Console.WriteLine("You enter the Foyer.");
            Console.WriteLine("You look around the Foyer. Up ahead are two winding staircases leading to the second floor, a set up against each wall.\n" +
                "On the ceiling is a looming chandelier hanging by a disturbingly feeble-looking chain. Beneath it is a worn rug, which you highly suspect\n" +
                "is infested with all manners of insects. At the back of the Foyer are two more doors, one leading to the living room, and another to the kitchen.");
            Console.ReadKey();
            while (keepLooping)
            {
                Console.Clear();
                Console.WriteLine("What will you do?\n" +
                    "1. Inspect Room\n" +
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
                            Console.Clear();
                            Console.WriteLine("You look around the Foyer. Up ahead are two winding staircases leading to the second floor, a set up against each wall.\n" +
                            "On the ceiling is a looming chandelier hanging by a disturbingly feeble-looking chain. Beneath it is a worn rug, which you highly suspect\n" +
                            "is infested with all manner of insects. At the back of the Foyer are two more doors, one leading to the living room, and another to the kitchen.");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.Clear();
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
                        break;
                    case 5:
                        Console.Clear();
                        if (chainBroken == false)
                        {
                            Console.WriteLine("You inspect the chandelier. It is tilted heavily, and looks as if it may fall at any moment. Its chain looks extremely feeble.\n" +
                                "If something were to hit it, it may give out entirely...");
                            Console.ReadKey();
                            if (glassCup == true)
                            {
                                Console.Clear();
                                Console.WriteLine("Were you to throw the glass cup you picked up in the kitchen at the chain, it just might be enough to fell the chandelier.\n" +
                                    "But why would you do that in the first place? Besides, you may need that cup later, and it's unlikely to survive the throw.\n" +
                                    "Do you want to throw the cup at the chain? Enter Yes or No");
                                string chainChoice = Console.ReadLine();
                                if (chainChoice == "Yes")
                                {
                                    glassCup = false;
                                    glassUsed = true;
                                    chainBroken = true;
                                    foyerKey = true;
                                    Console.Clear();
                                    Console.WriteLine("Knowing you only have one shot at this, you aim carefully, and with a deep breath, throw the cup with all your might.\n" +
                                        "Against all odds, the glass connects with the chain, and the chandelier crashes into the ground! The chandelier explodes upon contact\n" +
                                        "with the floor, and its debris is sent scattering across the room. A piece even strikes you with great force, but further inspection\n" +
                                        "reveals it to be no piece of the chandelier at all, but a key! What will it unlock, you wonder.");
                                    Console.ReadKey();
                                }
                                else if (chainChoice == "No")
                                {
                                    Console.Clear();
                                    Console.WriteLine("You decide against throwing the cup, and continue on your way.");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("Invalid input. Please type Yes or No.");
                                    Console.ReadKey();
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("The chandeliere lies shattered on the floor.");
                            Console.ReadKey();
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
            GhostAttack();
            bool keepLooping = true;
            while (keepLooping)
            {
                Console.Clear();
                Console.WriteLine("You enter the Kitchen.");
                Console.WriteLine("What will you do?\n" +
                    "1. Inspect Room\n" +
                    "2. Inspect Table\n" +
                    "3. Look in Drawers\n" +
                    "4. Look in Cabinets\n" +
                    "5. Go to Foyer\n" +
                    "6. Go to Wine Cellar\n" +
                    "7. Go to Garden");
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("You look around the Kitchen. In the center is an old wooden table with nothing adorning it. There are several cabinets and\n" +
                            "drawers lining the walls. Though there are windows as well, the broken glass deters you from attempting to climb through them. There are\n" +
                            "three doors in the room, one leading to the Foyer, one leading to the Garden, and another to the Wine Cellar.");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("You inspect the table. You can find nothing atop it. You crawl beneath the table in hopes that there might be something stuck\n" +
                            "to the bottom, but find nothing but cobwebs.");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        if (glassCup == false)
                        {
                            Console.WriteLine("You search through the drawers one by one, and find a single glass cup! You're not sure what it'll be good for, but you only\n" +
                                "have one, so you'd better be careful with it.");
                            Console.ReadKey();
                            glassCup = true;
                        }
                        else if (glassCup == true || glassUsed == true)
                        {
                            Console.WriteLine("You search the drawers again, but find nothing.");
                            Console.ReadKey();
                        }
                        break;
                    case 4:
                        Console.Clear();
                        if (attackedByBat == false)
                        {
                            Console.WriteLine("You open each cabinet one by one in search of something useful. You find nothing in any of them, but realize there's one last\n" +
                                "cabinet left to inspect. However, you feel an odd sense of dread as you stand before it. Will you risk opening it? Enter Yes or No.");
                            string response = Console.ReadLine();
                            if (response == "Yes")
                            {
                                Console.WriteLine("Ever the daredevil, you open the cabinet against your better judgment, only to be immediately attacked by a giant bat!\n" +
                                    "After clawing your face, it flies out the window. Unforuntately for you, there is nothing else in the cabinet. You lose 1 HP...");
                                player.Health = player.Health - 1;
                                attackedByBat = true;
                                Console.ReadKey();
                            }
                            else if (response == "No")
                            {
                                Console.WriteLine("Trusting your gut, you decide not to try your luck and leave the cabinet shut.");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter Yes or No.");
                                Console.ReadKey();
                            }
                        }
                        else
                        {
                            Console.WriteLine("You open each cabinet one by one in search of something useful. You find nothing in any of them, and considering what happened\n" +
                                "when there WAS something in one of them, you find yourself grateful for that.");
                            Console.ReadKey();
                        }
                        break;
                    case 5:
                        keepLooping = false;
                        Foyer();
                        break;
                    case 6:
                        keepLooping = false;
                        WineCellar();
                        break;
                    case 7:
                        keepLooping = false;
                        Garden();
                        break;
                    default:
                        break;
                }
            }
        }
        static void Garden()
        {
            GhostAttack();
            bool keepLooping = true;
            Console.Clear();
            Console.WriteLine("You arrive at the Garden.");
            Console.WriteLine("What will you do?\n" +
                "1. Inspect Garden\n" +
                "2. Inspect Flowerbeds\n" +
                "3. Inspect Fountain\n" +
                "4. Go to Front Yard\n" +
                "5. Go to Kitchen");
        }
        static void LivingRoom()
        {

        }
        static void Library()
        {
            GhostAttack();
            bool keepLooping = true;
            while (keepLooping)
            {
                Console.Clear();
                Console.WriteLine("You enter the Library.");
                Console.WriteLine("What will you do?\n" +
                    "1. Inspect Room\n" +
                    "2. Inspect Bookcase\n" +
                    "3. Look on Desk\n" +
                    "4. Look out Window\n" +
                    "5. Go to Foyer\n" +
                    "6. Go to Bedroom");
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("You look around the Library. The scent of cigar and old leather fills the room, the first pleasant room here. There are several bookcases and\n" +
                            "art lining the walls. The large windows makes this a well lit room. In the center of the room there is a large oak desk and papers scattered around the base of it There are\n" +
                            "two doors in the room, one leading to the Bedroom, one leading to back to the foyer.");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("You inspect the bookcase. It appears to have several old books. There are a few that seem to be still in tact. Maybe you can read one later...");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        if (lighter == true)
                        {
                            Console.WriteLine("You search the desk again, but find nothing.");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("You search through the drawers one by one, and find a Zippo! Don't go burning the place down now.");
                            Console.ReadKey();
                            lighter = true;
                        }
                        break;
                    case 4:
                        Console.Clear();
                        {
                            Console.WriteLine("You wipe off the dirt from the window and look out to your car in the front yard.\n" +
                                "Maybe theres still time to run out there and just drive off");
                        }
                        Console.ReadKey();
                        break;
                    case 5:
                        keepLooping = false;
                        Foyer();
                        break;
                    case 6:
                        if (ghostBones == true && ghostSkull == true && lighter == true) ;
                        break;
                    default:
                        break;
                }
            }
        }
        static void Crematorium()
        {
            GhostAttack();
            bool keepLooping = true;
            while (keepLooping)
            {
                Console.Clear();
                Console.WriteLine("You enter the Crematorium.");
                Console.WriteLine("What will you do?\n" +
                    "1. Inspect Room\n" +
                    "2. Inspect Furnace\n" +
                    "3. Cry\n" +
                    "4. Go to Wine Cellar");
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("You look around the Crematorium. The stench of burning corpses still flood the room. There are several furnaces\n" +
                            "where bodies were burned years ago. Though you are alone you feel surrounded in this room. There is\n" +
                            "one door in the room, leading back to the Wine cellar.");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        if (ghostBones == false)
                        {
                            Console.WriteLine("You inspect the Furnace. Still charred black you see a set of bones mangled on a tray. You grab the largest bones and take them with you,\n" +
                                "Ghost Bones added to your inventory.");
                            ghostBones = true;
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("There is nothing left in the furnace but ash.");
                            Console.ReadKey();
                        }
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Your breath shortens and your chest tightens up, the aroma of this room is too much to handle. After a good cry you feel a little better and gain" +
                            "one life point!");
                        player.Health = player.Health + 1;
                        Console.ReadKey();
                        break;
                    case 4:
                        keepLooping = false;
                        WineCellar();
                        break;
                    default:
                        break;

                }
            }
        }
    static void WineCellar()
    {
            GhostAttack();
            bool keepLooping = true;
            while (keepLooping)
            {
                Console.Clear();
                Console.WriteLine("You enter the Wine Cellar.");
                Console.WriteLine("What will you do?\n" +
                    "1. Inspect Room\n" +
                    "2. Inspect Wine Rack\n" +
                    "3. Have a Glass of Pinot\n" +
                    "4. Look in Trash Chute\n" +
                    "5. Go to Kitchen\n" +
                    "6. Go to Basement");
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("You look around the Wine Cellar. There are still hundreds of bottles lining the walls. There are several racks and\n" +
                            "a trash chute in the corner of the room. Strange to have a trash chute in a subfloor, wonder where it goes? There are\n" +
                            "two doors in the room, one leading to the Kitchen, one leading to back to the Basement.");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("You inspect the wine rack. Hundreds of untouched bottles still fill this room. You find a vintage Pinot Noir unopened,\n" +
                            "wonder if anyone will notice...");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("You grab one of the bottles and notice a small panel behind it, looks like a ring would fit right in there.");
                        if (gardenRing == false)
                        {
                            Console.WriteLine("there must be a ring laying around here somewhere...");
                        }
                        else
                        {
                            Console.WriteLine("You place the ring you found into the slot and hear rumbling as the wall opens to the next room");
                            Console.ReadKey();
                            Crematorium();
                        }
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                            Console.WriteLine("You open the chute that appears to have dried bloodstains streaked across the inside of the door.\n" +
                                "Whatever was being put in there was in rough shape.");
                        Console.ReadKey();
                        break;
                    case 5:
                        keepLooping = false;
                        LivingRoom();
                        break;
                    case 6:
                        keepLooping = false;
                        Basement();
                        break;
                    default:
                        break;
                }
            }
    }
        static void Basement()
        {
            GhostAttack();
            bool keepLooping = true;
            while (keepLooping)
            {
                Console.Clear();
                Console.WriteLine("You enter the Basement.");
                Console.WriteLine("What will you do?\n" +
                    "1. Inspect Room\n" +
                    "2. Inspect Table\n" +
                    "3. Look on Shelf\n" +
                    "4. Look in Cabinets\n" +
                    "5. Go to Living Room\n" +
                    "6. Go to Wine Cellar");
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("You look around the Basement. The musty stench from the moldy walls fill your nose. There are several cabinets and\n" +
                            "tools lining the walls. The small well windows give a little light to the room, for the most part its too dark to see what is around you. There are\n" +
                            "two doors in the room, one leading to the Wine Cellar, one leading to back to the Living room.");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("You inspect the table. It appears to be an old butchers table. You find skeletons of pigs and chickens scattered beneath the table,\n" +
                            "maybe a chicken is haunting these grounds");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        if (HasShovel == false)
                        {
                            Console.WriteLine("You search through the shelves one by one, and find a Shovel! If there was anything hidden in the garden, surely\n" +
                                "you can now find out.");
                            Console.ReadKey();
                            HasShovel = true;
                        }
                        else if (HasShovel == true || HasShovel == true)
                        {
                            Console.WriteLine("You search the shelves again, but find nothing.");
                            Console.ReadKey();
                        }
                        break;
                    case 4:
                        Console.Clear();
                        if (ghostSkull == false)
                        {
                            Console.WriteLine("You open the cabinet hoping to find something useful. You see something tangled up in cobwebs in the back but it\n" +
                                "is too dark to tell what it is. Do you grab it? Enter Yes or No");
                            string response = Console.ReadLine();
                            if (response == "Yes")
                            {
                                Console.WriteLine("You reach into the cabnet and pull a decayed skull from the webbing. You hear a voice call out to you saying 'did you loose your mind?'\n" +
                                    "Added Ghost Skull to your inventory");
                                ghostSkull = true;
                                Console.ReadKey();
                            }
                            else if (response == "No")
                            {
                                Console.WriteLine("Not wanting to get your hands covered in cobwebs, you decide to leave it be");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter Yes or No.");
                                Console.ReadKey();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Does not seem to be anything left in the cabinets");
                            Console.ReadKey();
                        }
                        Console.ReadKey();
                        break;
                    case 5:
                        keepLooping = false;
                        LivingRoom();
                        break;
                    case 6:
                        keepLooping = false;
                        WineCellar();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
