using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
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
        static bool gardenRing = false;
        static bool HasShovel = false;
        static bool UsedShovel = false;
        static bool bookPulled = false;
        static bool basementUnlocked = false;
        static bool ghostBones = false;
        static bool ghostSkull = false;
        static bool lighter = false;
        static Player player = new Player();

        public void Run()
        {
            RunApp();
        }
        public void RunApp()
        {
            bool keepLooping = true;
            Console.WriteLine("Name Of Game");
            Console.WriteLine("Please enter your name.");
            player.Name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Before you is a decrepit house, its wooden exterior rotting and grass long dead. The biting wind chills you to the bone,\n" +
                "and you decide suspect shelter is better than none. You enter the house, its dark and forboding atmosphere making you second guess your\n" +
                "decison. Alarm bells ring in your mind, and you quickly turn on your heel to flee. Before you can return to the wilderness, however, the\n" +
                "front door slams in your face, and much to your dismay, the handle will not turn. It would appear you are stuck here... Resolved to find\n" +
                "a way out, you decide to explore this house. There are two rooms you can access from the main hall.");
            End();
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
            bool keepLooping = true;
            while (keepLooping)
            {
                Console.Clear();
                Console.WriteLine("You arrive at the Foyer.");
                Console.WriteLine("What will you do?\n" +
                    "1. Inspect Room\n" +
                    "2. Go to Living Room\n" +
                    "3. Go to Kitchen\n" +
                    "4. Go to Front Yard\n" +
                    "5. Go to Library\n" +
                    "6. Go to Bedroom\n" +
                    "7. Inspect chandelier\n" +
                    "8. Inspect rug\n");
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        if (chainBroken == false)
                        {
                            Console.Clear();
                            Console.WriteLine("You look around the Foyer. Up ahead are two winding staircases leading to the second floor, a set up against each wall.\n" +
                                "The second floor seems to contain two rooms, the Library, and the Bedroom. On the ceiling is a looming chandelier hanging by a disturbingly\n" +
                                "feeble-looking chain. Beneath it is a worn rug, which you highly suspect is infested with all manner of insects. At the back of the Foyer\n" +
                                "are two more doors, one leading to the living room, and another to the kitchen.");
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
                        FrontYard();
                        break;
                    case 5:
                        keepLooping = false;
                        Library();
                        break;
                    case 6:
                        keepLooping = false;
                        Bedroom();
                        break;
                    case 7:
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
                    case 8:
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
            bool keepLooping = true;
            while (keepLooping)
            {
                Console.Clear();
                Console.WriteLine("You arrive at the Garden.");
                Console.WriteLine("What will you do?\n" +
                    "1. Inspect Garden\n" +
                    "2. Inspect Flowerbeds\n" +
                    "3. Inspect Fountain\n" +
                    "4. Inspect Bushes\n" +
                    "5. Go to Front Yard\n" +
                    "6. Go to Kitchen");
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("In the Garden you spot a dilapidated fountain in the corner, and abandonded, disheveled flowerbeds overgrown with\n" +
                            "weeds lining the edge of the garden. Overgrown bushes create a giant wall, preventing you from seeing outside the house's property.\n" +
                            "From here, you can return to the Front Yard, or go inside to the Kitchen.");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        if (HasShovel == false)
                        {
                            Console.WriteLine("You approach the flowerbeds. There's evidence of the flowerbeds being tampered with, but digging through all these\n" +
                                "by hand is hardly feasible. Maybe there's something somewhere around the house that will help you dig easier.");
                            Console.ReadLine();
                        }
                        else if (HasShovel == true)
                        {
                            Console.WriteLine("You approach the flowerbeds. There's evidence of the flowerbeds being tampered with. With the shovel you found,\n" +
                                "you dig through the flowerbeds, and in one of them, you find a human skeleton! You nearly run on instinct, but notice the\n" +
                                "skeleton has ring on one of its fingers. Not one to let anything go to waste, you decide to relieve the skeleton of its ring.\n" +
                                "It's for the enviorment, certainly not because you hope it's worth something, you tell yourself.");
                            gardenRing = true;
                            HasShovel = false;
                            UsedShovel = true;
                            Console.ReadKey();
                        }
                        else if (UsedShovel == true && HasShovel == false)
                        {
                            Console.WriteLine("You already inspected the flowerbeds and found a ring.");
                            Console.ReadKey();
                        }
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("You inspect the old fountain. It has long since dried up, and is filled only with leaves now. Unfortunately, even\n" +
                            "after digging through them, you find nothing of use.");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("You dive headfirst into the bushes, but obtain nothing but cuts and scratches. Luckily, your HP remains unchanged.");
                        Console.ReadKey();
                        break;
                    case 5:
                        keepLooping = false;
                        FrontYard();
                        break;
                    case 6:
                        keepLooping = false;
                        Kitchen();
                        break;
                    default:
                        break;
                }
            }
        }
        static void LivingRoom()
        {
            bool keepLooping = true;
            while (keepLooping)
            {
                Console.Clear();
                Console.WriteLine("You arrive at the Living Room.");
                Console.WriteLine("What will you do?\n" +
                    "1. Inspect Room\n" +
                    "2. Inspect Furniture\n" +
                    "3. Inspect Walls\n" +
                    "4. Go to Foyer\n" +
                    "5. Go to Basement");
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("You look around the Living Room. There is plenty of derelict furniture spread about, including a couch,\n" +
                            "bookshelf, and mini table. From here, you can access the Foyer, and the Basement. You feel the strange sense that you\n " +
                            "are not in this room alone. From one of the many cracks in the wooden walls, you can feel a gaze upon you.");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        if (bookPulled == false)
                        {
                            Console.WriteLine("You inspect the furniture in the room in hopes of finding something useful. You search under the cushions\n" +
                                "of the couch, on each shelf of the bookshelf, and in each drawer of the mini table. Unfortunately, you find nothing. However,\n" +
                                "you notice one of the books on the bookshelf seems suspiciously larger than the others. TOO suspicious. Pulling it seems the\n" +
                                "obvious choice, but it could be a trap. Will you risk it and pull the book? Enter Yes or No.");
                            string response = Console.ReadLine();
                            if (response == "Yes")
                            {
                                Console.Clear();
                                Console.WriteLine("You pull the book with hesitance, and hear an unnatural *clink*! You brace for the worst, but find that nothing\n" +
                                    "happens. At least, it would appear so at first glance. Something must have happened somewhere.");
                                bookPulled = true;
                                Console.ReadKey();
                            }
                            else if (response == "No")
                            {
                                Console.Clear();
                                Console.WriteLine("Trusting your instinct, you decide not to pull the book.");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Invalid input. Please enter Yes or No.");
                                Console.ReadKey();
                            }
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("You inspect the furniture again, but find nothing of use. The book on the bookshelf has already been pulled.");
                            Console.ReadKey();
                        }
                        break;
                    case 3:
                        Console.Clear();
                        if (bookPulled == false)
                        {
                            Console.WriteLine("You inspect the walls carefully and timidly, worried about the gaze you feel on the other side\n" +
                                "of the cracks. For a blessing, you find nothing of note.");
                            Console.ReadKey();
                        }
                        else if (bookPulled == true && foyerKey == false)
                        {
                            Console.WriteLine("You inspect the walls carefully and timidly, worried about the gaze you feel on the other side\n" +
                                "of the cracks. As you go along the wall, you spot a strange keyhole that wasn't there before. That's great\n" +
                                "and all... but where's the key?");
                            Console.ReadKey();
                        }
                        else if (bookPulled == true && foyerKey == true)
                        {
                            Console.WriteLine("You inspect the walls carefully and timidly, worried about the gaze you feel on the other side\n" +
                                "of the cracks. As you go along the wall, you spot a strange keyhole that wasn't there before. You insert the\n" +
                                "key you found in the foyer, and to your delight, it seems to fit like a glove! It probably unlocked the basement!");
                            basementUnlocked = true;
                            Console.ReadKey();
                        }
                        else if (basementUnlocked == true)
                        {
                            Console.Clear();
                            Console.WriteLine("You already unlocked the basement.");
                            Console.ReadKey();
                        }
                        Console.WriteLine();
                        break;
                    case 4:
                        keepLooping = false;
                        Foyer();
                        break;
                    case 5:
                        if (basementUnlocked == false)
                        {
                            Console.Clear();
                            Console.WriteLine("You try to enter the basement, but find the door locked. It seems you'll have to search for a key.");
                            Console.ReadKey();
                        }
                        else if (basementUnlocked == false && foyerKey == true)
                        {
                            Console.Clear();
                            Console.WriteLine("You attempt to use the key you found in the foyer to unlock the basement door, but you realize that\n" +
                                "there's no keyhole! There must be another way to unlock it.");
                            Console.ReadKey();
                        }
                        else if (basementUnlocked == true)
                        {
                            keepLooping = false;
                            Basement();
                        }
                        break;
                }
            }
        }
        static void FrontYard()
        {

        }

        static void Basement()
        {

        }

        static void WineCellar()
        {

        }
        static void Library()
        {

        }
        static void Bedroom()
        {
            Console.Clear();
            Console.WriteLine("You sense that this is the abode of the ghost. You should not enter until you are certain you're ready to face it.\n" +
                "Do you think you're ready? Enter Yes or No.");
            string response = Console.ReadLine();
            if (response == "Yes")
            {
                Console.Clear();
                Console.WriteLine("Feeling confident in your ability to exorcise the ghost, you enter its domain. As soon as you do, the ghost swoops down\n" +
                    "to strike! You narrowly avoid it and prepare to exorcise it.");
                Console.ReadKey();
                if (ghostSkull == false && ghostBones == false && lighter == false)
                {
                    Console.WriteLine("Oh no! You attempt to exorcise the ghost, but something's wrong! Your ritual has failed! It seems you did not have all\n" +
                        "the items necessary to purify its soul. Realizing your plans have failed, you attempt to flee, but the Bedroom door locks before you\n" +
                        "can escape through it. Now trapped with the ghost, you are left at its mercy. It seems this is the end of the line. The ghost swoops\n" +
                        "down and...");
                    Console.ReadKey();
                    player.Health = 0;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Feeling confident in your ability to exorcise the ghost, you enter its domain. As soon as you do, the ghost swoops down\n" +
                        "to strike! You narrowly avoid it and prepare to exorcise it.");
                    Console.WriteLine("You place the skull and bones in the center of the room and light them with the lighter! The ghost writhes in agony before\n" +
                        "vanishing right before your eyes. The exorcism was a success! The ghost has been purified. Your job finished, you leave the house, another\n" +
                        "job completed.");
                    Console.ReadKey();
                    End();
                }
            }
            else if (response == "No")
            {
                Console.Clear();
                Console.WriteLine("You feel that there is yet more to prepare, and return to the Foyer to continue your preparations.");
                Console.ReadKey();
                Foyer();
            }
            else
            {
                Console.WriteLine("Invalid Selection. Please enter Yes or No.");
                Console.ReadKey();
                Foyer();
            }
        }

        static void End()
        {
            System.Console.ReadLine();
        }
    }
}


