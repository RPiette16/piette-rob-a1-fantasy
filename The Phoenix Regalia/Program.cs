// See https://aka.ms/new-console-template for more information
// Set the stage for the adventure and get the player name.
Console.WriteLine("Hello Adventurer, what shall we call you?");
string Name = Console.ReadLine();
// Broke up the text into multiple Write lines for ease of reading the code rather than one ridiculous long line.
Console.Write($"Ah {Name}, a good strong name! Welcome to the world of Talamor, a wonderous land of magic and adventure.");
Console.Write(" Your story begins on a ship headed for the country of Gaelia, to a small port town known as Locksar town.");
Console.Write(" You recieved a letter on your travels from a Mr Snyde asking you to come to Locksar town to help him kill a terrible creature plaguing the town");
Console.Write(" and so you bought passage on a ship for the promise of gold and glory!");
Console.WriteLine(" As the ship docks at the harbor you take one final look at the letter. \nDo you wish to Dissembark or Stay?");

string decision = Console.ReadLine();
if (decision == "Stay")
{
    Console.WriteLine(" You let the letter fall into the water and decide to stay aboard the ship and see where the wind will take you. Game Over.");
}
else if (decision == "Dissembark")
{
    Console.Write("\n\nYou take your leave of the ship and are greated by a gangly man standing next to a carriage.");
    Console.Write($" Good morrow! You must be {Name}, I am Mr Snyde's butler and I am to take you to the keep at once.");
    Console.Write(" You hop into the carriage and ride through the towns main road, taking note of the three houses in town that were burnt to ashes.");
    Console.Write(" \n\nYou arrive at the keep of Mr Snyde, taking note of his incredible wealth compared to the other townsfolk.");
    Console.Write(" A small round man comes down the staircase in the main hall and addresses you.");
    Console.Write($" \n\nHello {Name}, I have been waiting quite some time for an adventurer of your calibre to save this town from its curse!");
    Console.Write(" Mr. Snyde tells you he used to be an adventurer in his youth. Along with three companions from Locksar they went on many adventures.");
    Console.Write(" One such adventure involved the creature that plagues the town now, a Black Phoenix!");
    Console.Write(" Seeing the doubt on your face as to the task of killing a phoenix he explains that he and his companions found a way to kill a phoenix permanently.");
    Console.Write(" When the phoenix ashes after defeat, amongst the ashes you will find a crested jewel. This regalia if it is destroyed before the phoenix rises again will prevent it from ever rising, killing it forever.");
    Console.Write($" \n\nThe creature is killing the townsfolk and burning their homes, it resides in the mountain on the other side of the woods east of town please help us {Name}, you are our only hope.");
    
    Console.WriteLine("\nTo kill a phoenix will be no easy task. \nDo you Accept or Decline this quest?");

    string choice = Console.ReadLine();
    if (choice == "Decline")
    {
        Console.WriteLine("Coward! You are no adventurer. Game Over.");
    }
    else if (choice == "Accept")
    {
        Console.WriteLine(" You finish your meeting with Mr Snyde and focus yourself on your task. You know your weapon will need to be sharpened before the fight so you head to the blacksmith.");
        Console.WriteLine("\n\nYou arrive at the blacksmith and look into your gold pouch, How much gold do you have?");
        string input = Console.ReadLine();
        int gold = int.Parse(input);

        Console.WriteLine($" You have {gold} gold? A brand new greatsword costs 25 gold and I can sharpen your old one if you dont have enough. Speaks the blacksmith");
        if (gold >= 25)
        {
            Console.WriteLine("\n\nExcellent, here is your brand new greatsword, perfect for felling the greatest of enemies!");
            gold = gold - 25;
            Console.WriteLine($" You have {gold} gold left. Good luck adventurer.");
        }
        else if (gold < 25)
        {
            Console.WriteLine(" Oh, looks like you dont have enough. Let me take a look at your old one.");
            Console.WriteLine(" There you are, good as new! Safe travels!");
        }
        Console.Write("You set out towards the east end of town and see over the trees that the main road ahead goes around the woods rather than through.");
        Console.Write(" If you cut through the woods you will get to the mountain faster but there is no telling what dangers may lie in wait on either path.");
        Console.WriteLine("\nWhat will you do? Do you wish to take the Road or cut through the Woods?");

        string path = Console.ReadLine();
        if (path == "Road")
        {
            Console.Write("\n\nYou walk the main road for a while until you come upon a broken down carriage sitting in the middle of the road.");
            Console.Write(" As you get closer you notice fresh holes in the side of the cart, and it looks like the wheel was taken off not broken");
            Console.Write("\nIts a Trap! Six bandits emerge from the tree line, you fight them as long as you can before an archer gets a shot to stick.");
            Console.Write(" You fall to one knee and look up to see the blade just before it strikes. \nYou are dead. Game Over");
        }
        else if (path == "Woods")
        {
            Console.Write("\n\nYou march straight through the woods and arrive at the foot of the mountain safe.");
            Console.Write(" You see a cave entrance that leads into the mountain and you step inside. You can hear distant drip noises as you walk deeper into the cave");
            Console.Write(" As you move deeper into the mountain it begins getting hotter and hotter.You come to a fork in the tunnels ahead.");
            Console.WriteLine("Do you take the Left or Right tunnel?");

            string tunnel = Console.ReadLine();
            if (tunnel == "Left")
            {
                Console.Write("\n\nYou step through the tunnel cautiously not sure of what you may encounter, the heat is becoming more and more of a challenge.");
                Console.Write(" As you round a corner you notice a strange creature floating at the end of the tunnel, it turns as it notices you.");
                Console.Write(" You come face to face with a Beholder! Its many tenticled eyes turn on you and begin to glow as you feel your body turn to stone.");
                Console.WriteLine(" You are dead. Game Over.");
            }
            else if (tunnel == "Right")
            {
                Console.Write("\n\nYou walk through the tunnel eventually getting to a bridged cavern that is lit up ahead.");
                Console.Write(" Once at the bridge you notice the light is coming from the liquid magma below, this is no mountain but a volcano!");
                Console.Write(" You tread carefully across the bridge careful not to fall to your death below. With the bridge behind you, you travel into a large chamber of the cave.");
                Console.Write(" The heat here is unbearable, sweat is freely flowing and its hard to breathe. Even your armour is burning hot to touch bare handed.");
                Console.Write(" \n\nThe back of the cavern is pitch black, and you cant explain it but as you look into the blackness you are overwhelmed with sadness.");
                Console.Write(" Its then that you notice the blackness is moving! It shifts and turns as a purple flame takes form. You are face to face with the Black Phoenix.");
                Console.Write(" The Phoenix eyes you carefully but doesnt move, you dont feel danger from the creature just the overwhelming sadness.");
                Console.Write("\n\nYou begin to look around the chamber and see a pile of rubble over in the corner close to the Phoenix. You cautiously approach the pile, watchful of the Phoenix.");
                Console.Write(" In the rubble you find the shards of large eggs, a burnt shield, a broken axe and arrowheads. The Phoenix lets out a cry and the sadness you felt before was nothing compared to this.");

                Console.Write(" The Phoenix cry turns to rage and you jump back instictivly. Mr Snyde enters the chamber with four mercenaries, their weapons drawn");
                Console.Write($"\n\nMr Snyde yells out to you. Strike now {Name}, I have brought you help to defeat the monster!");
                Console.Write(" The moment has come and you must make your decision, you could side with Mr Snyde and fight the Phoenix, side with the Phoenix and fight the mercenaries or you could take your leave.");
                Console.WriteLine("What will you do, One, fight the Phoenix, Two, fight the mercenaries or Three, leave them to each other.");

                string outcome = Console.ReadLine();
                if (outcome == "One")
                {
                    Console.WriteLine("\n\nYou charge the Phoenix weapon drawn and see it rise up and stretch its wings, unleashing a wave of purple and black flames annihilating you and everyone else in an instant. \nYou are dead. Game over.");
                }
                else if (outcome == "Two")
                {
                    Console.Write("\n\nYou charge the mercenaries, catching them off guard. Moving with sure purpose you cut your way through them saving Mr Snyde for last.");
                    Console.Write(" You confront him about the egg shards and destroyed gear sure of your intuition. Mr Snyde confesses to having murdered the Phoenix offspring in an attempt to steal them years before.");
                    Console.Write(" The result being that when the Phoenix ashed of a broken heart it was reborn as a Black Phoenix a creature of pure revenge and sadness.");
                    Console.Write(" Justified in your decision you swing your blade one more time avenging the poor Phoenix and her children. The Phoenix seeing what you have done ashes and from the ashes rises again a normal phoenix.");
                    Console.Write(" The newly born Phoenix bends down to you and gifts you a single crystalized tear known for its healing powers and rumored to even bring someone back from the dead.");

                    Console.Write("\n\nYou returned to Locksar town and are greeted by the whole town, because you saved them from the Phoenix and Mr Snyde they offer you his wealth and his home!");
                    Console.WriteLine($" Congratulations {Name}, you have won!");
                }
                else if (outcome == "Three")
                {
                    Console.Write("\n\nYou wash your hands of this whole mess and walk out of the chamber the way you came. You can hear the screams of the ones you left behind and the roar of a fire as you make your way back to the entrance of the cave.");
                    Console.Write(" As you exit the cave and make your way to the woods you see a phoenix flying overhead but no longer black, now it shines brilliant like a flame.");
                    Console.Write(" The towns folk all thank you for freeing them of the creature and Mr Snyde, you tell them you simply left them to fight each other but they insist they want you to take Mr Snydes house as your own and become their resident Hero.");
                    Console.WriteLine(" Congratulations, You survived to the journies end!");
                }
            }
        }
    }


}
