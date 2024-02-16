namespace adventureNovel;

// Each method call is a different branch the player can enter to have different choices and respective outcomes. All options available to a player needed to be provivded depending on what actions they have,
// or have not taken. This often involves large and nested if...else statement determining the options that the player should be provided with.
// The switch statements within these if..else statements (although not always if non-standard options are to be provided) are used to determine the next methods to call based on options provided to the player.
class IntroductionCave
{

    static void Main(string[] args)
    {
        Console.Clear();
        Introduction();
        Console.WriteLine("End of game.");
    }

    static void Introduction()
    {
        Console.WriteLine("You wake up and find youself in a dark cave.\nThrough a small crack of the rocks above, a dim light shines through allowing you to just make out a large wooden door before you.");
        string[] options = { "Open the door.", "Knock on the door.", "Look around the cave." };
        int currentAnswer = UtilityMethods.PromptAndValidateUserInput(options);

        switch (currentAnswer)
        {
            case 1:
                OpenTheDoor();
                break;
            case 2:
                KnockOnTheDoor();
                break;
            case 3:
                LookAroundCave();
                break;
        }
    }

    static void OpenTheDoor()
    {
        if (CaveVaraibles.doorMonsterAnnoyed == true)
        {
            Console.WriteLine("You push open the door. The moment you step into the next room, before having even a moment to process what you have seen, you hear a wickid growl fiercly and without a second to spare everything turns black. Gamne over.");
        }
        else if (CaveVaraibles.doorMonsterAnnoyed == false)
        {
            if (CaveVaraibles.doorUnlocked == false)
            {
                if (CaveVaraibles.lockInspected == false)
                {
                    Console.WriteLine("You push on the door but it doesn't move.");
                    string[] options = { "Kick at the door with force.", "Inspect the lock of the door.", "Knock on the door.", "Look around the cave." };
                    int currentAnswer = UtilityMethods.PromptAndValidateUserInput(options);

                    switch (currentAnswer)
                    {
                        case 1:
                            KickAtTheDoor();
                            break;
                        case 2:
                            InspectTheLock();
                            break;
                        case 3:
                            KnockOnTheDoor();
                            break;
                        case 4:
                            LookAroundCave();
                            break;
                    }
                }
                else if (CaveVaraibles.lockInspected == true)
                {
                    Console.WriteLine("You push on the door but it doesn't move.");
                    string[] options = { "Kick at the door with force.", "Knock on the door.", "Look around the cave." };
                    int currentAnswer = UtilityMethods.PromptAndValidateUserInput(options);

                    switch (currentAnswer)
                    {
                        case 1:
                            KickAtTheDoor();
                            break;
                        case 2:
                            KnockOnTheDoor();
                            break;
                        case 3:
                            LookAroundCave();
                            break;
                    }
                }
            }
            else if (CaveVaraibles.doorUnlocked == true)
            {
                Console.WriteLine("You open the door, and it swings slowly to reveal a fairly small, dusty but well furnished libary. Bookshelves stack the sides of the room.");
                Libary.EnterTheLibrary();
            }
        }
    }

    static void KnockOnTheDoor()
    {
        CaveVaraibles.doorKnockedCount++;
        if (CaveVaraibles.doorMonsterAnnoyed == true)
        {
            Console.WriteLine("You knock and the sound echo's throughout the cave walls.\nAfter a moment of waiting, the door throws itself open, and before you stands a mighty scaled beast.\nIt growls fiercly at you, and without a second to spare it pounces at you. Gamne over.");
        }
        else if (CaveVaraibles.doorMonsterAnnoyed == false)
        {
            if (CaveVaraibles.lockInspected == true)
            {
                if (CaveVaraibles.doorKnockedCount == 1)
                {
                    Console.WriteLine("You knock and the sound echo's throughout the cave walls.\nAfter a moment of waiting, all you hear is silence.");
                }
                else if (CaveVaraibles.doorKnockedCount == 2)
                {
                    Console.WriteLine("You knock once again. The sound echo's throughout the cave walls.\nAfter a moment of waiting, you hear a muffled rustle beyond the walls.");
                }
                else if (CaveVaraibles.doorKnockedCount == 3)
                {
                    Console.WriteLine("You knock a third time. The sound echo's throughout the cave walls.\nAfter a moment of waiting, you hear the lock click.");
                    CaveVaraibles.doorUnlocked = true;
                }
                else if (CaveVaraibles.doorKnockedCount == 4)
                {
                    Console.WriteLine("You knock a forth time. The sound echo's throughout the cave walls.\nAfter a moment of waiting, a claw swipes blindingly quick at you.");
                    return;
                }
                string[] options = { "Open the door.", "Knock on the door.", "Look around the cave." };
                int currentAnswer = UtilityMethods.PromptAndValidateUserInput(options);
                switch (currentAnswer)
                {
                    case 1:
                        OpenTheDoor();
                        break;
                    case 2:
                        KnockOnTheDoor();
                        break;
                    case 3:
                        LookAroundCave();
                        break;
                }
            }
            else if (CaveVaraibles.lockInspected == false)
            {
                if (CaveVaraibles.doorKnockedCount == 1)
                {
                    Console.WriteLine("You knock and the sound echo's throughout the cave walls.\nAfter a moment of waiting, all you hear is silence.");
                }
                else if (CaveVaraibles.doorKnockedCount == 2)
                {
                    Console.WriteLine("You knock once again. The sound echo's throughout the cave walls.\nAfter a moment of waiting, you hear a muffled rustle beyond the walls.");
                }
                else if (CaveVaraibles.doorKnockedCount == 3)
                {
                    Console.WriteLine("You knock a third time. The sound echo's throughout the cave walls.\nAfter a moment of waiting, you hear the lock click.");
                    CaveVaraibles.doorUnlocked = true;
                }
                else if (CaveVaraibles.doorKnockedCount == 4)
                {
                    Console.WriteLine("You knock a forth time. The sound echo's throughout the cave walls.\nAfter a moment of waiting, a claw swipes blindingly quick at you.");
                    return;
                }
                string[] options = { "Open the door.", "Inspect the lock of the door.", "Knock on the door.", "Look around the cave." };
                int currentAnswer = UtilityMethods.PromptAndValidateUserInput(options);
                switch (currentAnswer)
                {
                    case 1:
                        OpenTheDoor();
                        break;
                    case 2:
                        InspectTheLock();
                        break;
                    case 3:
                        KnockOnTheDoor();
                        break;
                    case 4:
                        LookAroundCave();
                        break;
                }
            }
        }
    }

    static void LookAroundCave()
    {
        CaveVaraibles.timesLookedAroundCave++;

        switch (CaveVaraibles.timesLookedAroundCave)
        {
            case 1:
                Console.WriteLine("You look around the cave, glancing about to see anything else. You notice what appears to be a dusty off-white balls and sticks scatted across the sides of the doors entrance.");
                break;
            case 2:
                Console.WriteLine("You look further around the cave, leaning down to the objects you noticed earlier. Upon closer inspection you can see that these are the skeletal remains of whom-ever passed away here.");
                break;
            case 3:
                Console.WriteLine("You once again take a further look around the cave. You notice a dusty, dulled but still just about shiny inscription on the other side of the cave wall.");
                break;
            case 4:
                Console.WriteLine("You decide to lean over to the inscription and read it. Wiping of the dirt, you notice it reads\n\"The polite and patient are welcome. Those who insist or are incessant are most certainly not welcome.\"");
                break;
            case 5:
                Console.WriteLine("A further investigation of the small cave leads you to look under a small rock that appears oddly different from the surronding cave material. You decide to pocket it and take it with you.");
                PlayerVaraibles.smallRockTaken = false;
                break;
            default:
                Console.WriteLine("You take a gander once more, but the cave is only small. You appear to no longer find any further items of interest.");
                break;
        }

        if (CaveVaraibles.lockInspected == false)
        {
            string[] options = { "Open the door.", "Inspect the lock of the door.", "Knock on the door.", "Look around the cave." };
            int currentAnswer = UtilityMethods.PromptAndValidateUserInput(options);
            switch (currentAnswer)
            {
                case 1:
                    OpenTheDoor();
                    break;
                case 2:
                    InspectTheLock();
                    break;
                case 3:
                    KnockOnTheDoor();
                    break;
                case 4:
                    LookAroundCave();
                    break;
            }
        }
        else if (CaveVaraibles.lockInspected == true)
        {
            string[] options = { "Open the door.", "Knock on the door.", "Look around the cave." };
            int currentAnswer = UtilityMethods.PromptAndValidateUserInput(options);
            switch (currentAnswer)
            {
                case 1:
                    OpenTheDoor();
                    break;
                case 2:
                    KnockOnTheDoor();
                    break;
                case 3:
                    LookAroundCave();
                    break;
            }
        }

    }

    static void KickAtTheDoor()
    {
        Console.WriteLine("You step back to ready yourself. Then, in one clean motion you lunge forward on one foot, the other raised up.\nThe raised foot crashes into the door, booming the rocky cave will deafening echos.\nAfter the last of the loose rocks finish falling down from above, you hear a violent metallic snap within the door");
        CaveVaraibles.doorMonsterAnnoyed = true;

        if (CaveVaraibles.lockInspected == false)
        {
            string[] options = { "Open the door.", "Inspect the lock of the door.", "Knock on the door.", "Look around the cave." };
            int currentAnswer = UtilityMethods.PromptAndValidateUserInput(options);
            switch (currentAnswer)
            {
                case 1:
                    OpenTheDoor();
                    break;
                case 2:
                    InspectTheLock();
                    break;
                case 3:
                    KnockOnTheDoor();
                    break;
                case 4:
                    LookAroundCave();
                    break;
            }
        }
        else if (CaveVaraibles.lockInspected == true)
        {
            string[] options = { "Open the door.", "Knock on the door.", "Look around the cave." };
            int currentAnswer = UtilityMethods.PromptAndValidateUserInput(options);
            switch (currentAnswer)
            {
                case 1:
                    OpenTheDoor();
                    break;
                case 2:
                    KnockOnTheDoor();
                    break;
                case 3:
                    LookAroundCave();
                    break;
            }
        }
    }

    static void InspectTheLock()
    {
        CaveVaraibles.lockInspected = true;
        Console.WriteLine("You move your face towards to lock. It appears to be welded shut, as if the lock is no longer in use. It clearly can no longer be used regardless.");
        string[] options = { "Open the door.", "Knock on the door.", "Look around the cave." };
        int currentAnswer = UtilityMethods.PromptAndValidateUserInput(options);
        switch (currentAnswer)
        {
            case 1:
                OpenTheDoor();
                break;
            case 2:
                KnockOnTheDoor();
                break;
            case 3:
                LookAroundCave();
                break;
        }

    }
}


