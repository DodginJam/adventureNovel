namespace adventureNovel;

// Each method call is a different branch the player can enter to have different choices and respective outcomes. All options available to a player needed to be provivded depending on what actions they have,
// or have not taken. This often involves large and nested if...else statement determining the options that the player should be provided with.
// The switch statements within these if..else statements (although not always if non-standard options are to be provided) are used to determine the next methods to call based on options provided to the player.
class Libary
{
    public static void EnterTheLibrary()
    {
        Console.WriteLine("You step forward into the libary. You eyes are immeditatly drawn to a plinth, upon which rests a round golden glass container placed at the centre of the room.");
        string[] options = { "Look around the libary.", "Turn back through the door.", "Inspect the Golden Container", "Open the Golden Container." };
        int currentAnswer = UtilityMethods.PromptAndValidateUserInput(options);
        switch (currentAnswer)
        {
            case 1:
                LookAroundLibary();
                break;
            case 2:
                TurnAround();
                break;
            case 3:
                InspectTheGoldenContainer();
                break;
            case 4:
                OpenTheGoldenContainer();
                break;
        }
    }

    static void LookAroundLibary()
    {
        // First determines whether player has looked around yet already - ensures different text output whether inspecting for first time or not.
        if (LibaryVaraibles.lookedAround == false)
        {
            LibaryVaraibles.lookedAround = true;
            Console.WriteLine("You look around the libary and notice again the two bookshelves either side of the room.\nThe left side is labeled \"Works of fiction\" while the right side is labeled \"Natural Histories\".\nThey appear to contain different works however you have never heard of any of them before.");
        }
        else if (LibaryVaraibles.lookedAround == true)
        {
            Console.WriteLine("After another quick glance around the libary, you do not find any other objects of note.");
        }

        // If...else statement used to cover every possible scenario in for available player options.
        if (LibaryVaraibles.turnedAround == false)
        {
            string[] options = { "Look around the libary.", "Turn back through the door.", "Inspect the Golden Container", "Open the Golden Container.", "Inspect the \"Works of Fiction\" shelf.", "Inspect the \"Natural Histories\" shelf." };
            int currentAnswer = UtilityMethods.PromptAndValidateUserInput(options);
            switch (currentAnswer)
            {
                case 1:
                    LookAroundLibary();
                    break;
                case 2:
                    TurnAround();
                    break;
                case 3:
                    InspectTheGoldenContainer();
                    break;
                case 4:
                    OpenTheGoldenContainer();
                    break;
                case 5:
                    InspectWorksOfFicton();
                    break;
                case 6:
                    InspectNaturalHistories();
                    break;
            }
        }
        else if (LibaryVaraibles.turnedAround == true)
        {
            string[] options = { "Look around the libary.", "Inspect the Golden Container", "Open the Golden Container.", "Inspect the \"Works of Fiction\" shelf.", "Inspect the \"Natural Histories\" shelf." };
            int currentAnswer = UtilityMethods.PromptAndValidateUserInput(options);
            switch (currentAnswer)
            {
                case 1:
                    LookAroundLibary();
                    break;
                case 2:
                    InspectTheGoldenContainer();
                    break;
                case 3:
                    OpenTheGoldenContainer();
                    break;
                case 4:
                    InspectWorksOfFicton();
                    break;
                case 5:
                    InspectNaturalHistories();
                    break;
            }
        }
    }
    static void TurnAround()
    {
        LibaryVaraibles.turnedAround = true;
        // If...else statement used to cover every possible scenario in for available player options.
        if (LibaryVaraibles.lookedAround == false)
        {
            Console.WriteLine("You turn to face back from where you came. The door you entered through has seemingly disappeared. All that was behind you is a brick wall. How odd.");
            string[] options = { "Look around the libary.", "Inspect the Golden Container", "Open the Golden Container." };
            int currentAnswer = UtilityMethods.PromptAndValidateUserInput(options);
            switch (currentAnswer)
            {
                case 1:
                    LookAroundLibary();
                    break;
                case 2:
                    InspectTheGoldenContainer();
                    break;
                case 3:
                    OpenTheGoldenContainer();
                    break;
            }
        }
        else if (LibaryVaraibles.lookedAround == true)
        {
            Console.WriteLine("You turn to face back from where you came. The door you entered through has seemingly disappeared. All that was behind you is a brick wall. How odd.");
            string[] options = { "Look around the libary.", "Inspect the Golden Container", "Open the Golden Container.", "Inspect the \"Works of Fiction\" shelf.", "Inspect the \"Natural Histories\" shelf." };
            int currentAnswer = UtilityMethods.PromptAndValidateUserInput(options);
            switch (currentAnswer)
            {
                case 1:
                    LookAroundLibary();
                    break;
                case 2:
                    InspectTheGoldenContainer();
                    break;
                case 3:
                    OpenTheGoldenContainer();
                    break;
                case 4:
                    InspectWorksOfFicton();
                    break;
                case 5:
                    InspectNaturalHistories();
                    break;
            }
        }

    }
    static void InspectTheGoldenContainer()
    {

        // First determines glass container inspected or not - ensures different text output whether inspecting for first time or not.
        // Different outputs depending on books placed on Golden Container.
        if (LibaryVaraibles.glassContainerInspected == false)
        {
            LibaryVaraibles.glassContainerInspected = true;
            Console.WriteLine("You take a closer look at the Golden Container. A shimmering of hot air emenates from around it. Within the container is a highly decorated yet ancient looking parchment.\nThe base of the container has two dull gems below which are two respective rectangular inprints.");
        }
        else if (LibaryVaraibles.glassContainerInspected == true)
        {
            if (LibaryVaraibles.correctLibaryBooks[0] == true && LibaryVaraibles.correctLibaryBooks[1] == true)
            {
                Console.WriteLine("You look close at the Golden Container. You see the two gems glow brightly, and the shimmering air around the container has ceased.");
            }
            else if (LibaryVaraibles.correctLibaryBooks[0] == true && LibaryVaraibles.correctLibaryBooks[1] == false)
            {
                Console.WriteLine("You look close at the Golden Container. You see the left gem glow brightly, while the right gem remains dim. The shimmering air around the container continues.");
            }
            else if (LibaryVaraibles.correctLibaryBooks[0] == false && LibaryVaraibles.correctLibaryBooks[1] == true)
            {
                Console.WriteLine("You look close at the Golden Container. You see the right gem glow brightly, while the left gem remains dim. The shimmering air around the container continues.");
            }
            else if (LibaryVaraibles.correctLibaryBooks[0] == false && LibaryVaraibles.correctLibaryBooks[1] == false)
            {
                Console.WriteLine("You look close at the Golden Container. You see the two gems remain dim, and the shimmering air around the container continues.");
            }
        }

        // Very large nested if...else statements are used to cover every possible scenario in for available player options.
        if (LibaryVaraibles.lookedAround == false)
        {
            if (LibaryVaraibles.turnedAround == false)
            {
                string[] options = { "Look around the libary.", "Turn back through the door.", "Inspect the Golden Container", "Open the Golden Container." };
                int currentAnswer = UtilityMethods.PromptAndValidateUserInput(options);
                switch (currentAnswer)
                {
                    case 1:
                        LookAroundLibary();
                        break;
                    case 2:
                        TurnAround();
                        break;
                    case 3:
                        InspectTheGoldenContainer();
                        break;
                    case 4:
                        OpenTheGoldenContainer();
                        break;
                }
            }
            else if (LibaryVaraibles.turnedAround == true)
            {
                string[] options = { "Look around the libary.", "Inspect the Golden Container", "Open the Golden Container." };
                int currentAnswer = UtilityMethods.PromptAndValidateUserInput(options);
                switch (currentAnswer)
                {
                    case 1:
                        LookAroundLibary();
                        break;
                    case 2:
                        InspectTheGoldenContainer();
                        break;
                    case 3:
                        OpenTheGoldenContainer();
                        break;
                }
            }
        }
        else if (LibaryVaraibles.lookedAround == true)
        {
            if (LibaryVaraibles.turnedAround == false)
            {
                string[] options = { "Look around the libary.", "Turn back through the door.", "Inspect the Golden Container", "Open the Golden Container.", "Inspect the \"Works of Fiction\" shelf.", "Inspect the \"Natural Histories\" shelf." };
                int currentAnswer = UtilityMethods.PromptAndValidateUserInput(options);
                switch (currentAnswer)
                {
                    case 1:
                        LookAroundLibary();
                        break;
                    case 2:
                        TurnAround();
                        break;
                    case 3:
                        InspectTheGoldenContainer();
                        break;
                    case 4:
                        OpenTheGoldenContainer();
                        break;
                    case 5:
                        InspectWorksOfFicton();
                        break;
                    case 6:
                        InspectNaturalHistories();
                        break;
                }
            }
            else if (LibaryVaraibles.turnedAround == true)
            {
                string[] options = { "Look around the libary.", "Inspect the Golden Container", "Open the Golden Container.", "Inspect the \"Works of Fiction\" shelf.", "Inspect the \"Natural Histories\" shelf." };
                int currentAnswer = UtilityMethods.PromptAndValidateUserInput(options);
                switch (currentAnswer)
                {
                    case 1:
                        LookAroundLibary();
                        break;
                    case 2:
                        InspectTheGoldenContainer();
                        break;
                    case 3:
                        OpenTheGoldenContainer();
                        break;
                    case 4:
                        InspectWorksOfFicton();
                        break;
                    case 5:
                        InspectNaturalHistories();
                        break;
                }
            }
        }
    }
    static void OpenTheGoldenContainer()
    {
        // If player has solved the puzzle, the player is given a forced choice to lead to next scene. If puzzle remains unsolved, they are burned and provided room options.
        if (LibaryVaraibles.correctLibaryBooks[0] == true && LibaryVaraibles.correctLibaryBooks[1] == true)
        {
            Console.WriteLine("You grab at the sides of the Golden Glass Container, which is warm to the touch. You lift up the Container Glass lid and place it aside the plinth, on the floor.\nYou grab that scroll and feel a strong wave of compulsion thoughout your entire being.\nYou have never felt such certainty in your life - although for what, you are not quite sure.");
            string[] options = { "Read The Scroll.", "Place The Scroll back down." };
            int currentAnswer = UtilityMethods.PromptAndValidateUserInput(options);
            switch (currentAnswer)
            {
                case 1:
                    ReadTheScroll();
                    break;
                case 2:
                    PlaceTheScrollBackDown();
                    break;
            }
        } // The player game ends if burned enough, as control flow ends via return.  
        else if (LibaryVaraibles.correctLibaryBooks[0] == false || LibaryVaraibles.correctLibaryBooks[1] == false)
        {
            PlayerVaraibles.burnedHands = true;
            LibaryVaraibles.timesBurned++;
            string burnMessage = "";
            if (LibaryVaraibles.timesBurned == 1)
            {
                burnMessage = "You grab at the sides of Golden Glass Container. You feel a searing pain and you rip your hands away instictually.\nYour hands throb with pain and appear bright red.";
            }
            else if (LibaryVaraibles.timesBurned == 2)
            {
                burnMessage = "You grab at the sides of Golden Glass Container. Your already raw hands fill with excruciating pain, and you whip your hands off the glass.\nYour hands appear charred and your nerves feel on fire. You sweat profusely and feel faint.";
            }
            else if (LibaryVaraibles.timesBurned >= 3)
            {
                Console.WriteLine("You grab at the sides of Golden Glass Container. You rip your hands back. You start to feel numb.\nYou look down and see your mangled hands - your crisp hands are filled with boils alike melted wax, with blackened stumps in place of your finger.\nYour vision starts to go dark. You collapse.");
                return;
            }

            // Large nested if...else statements that follow cover all room options scenarios as to whether player has turned around or not (removing TurnAround method availability), and whether played has looked around the Libary (added options to inspect either 
            // of the two bookshelves).
            if (LibaryVaraibles.lookedAround == false)
            {
                if (LibaryVaraibles.turnedAround == false)
                {
                    Console.WriteLine($"{burnMessage}");
                    string[] options = { "Look around the libary.", "Turn back through the door.", "Inspect the Golden Container", "Open the Golden Container." };
                    int currentAnswer = UtilityMethods.PromptAndValidateUserInput(options);
                    switch (currentAnswer)
                    {
                        case 1:
                            LookAroundLibary();
                            break;
                        case 2:
                            TurnAround();
                            break;
                        case 3:
                            InspectTheGoldenContainer();
                            break;
                        case 4:
                            OpenTheGoldenContainer();
                            break;
                    }
                }
                else if (LibaryVaraibles.turnedAround == true)
                {
                    Console.WriteLine($"{burnMessage}");
                    string[] options = { "Look around the libary.", "Inspect the Golden Container", "Open the Golden Container." };
                    int currentAnswer = UtilityMethods.PromptAndValidateUserInput(options);
                    switch (currentAnswer)
                    {
                        case 1:
                            LookAroundLibary();
                            break;
                        case 2:
                            InspectTheGoldenContainer();
                            break;
                        case 3:
                            OpenTheGoldenContainer();
                            break;
                    }
                }
            }
            else if (LibaryVaraibles.lookedAround == true)
            {
                if (LibaryVaraibles.turnedAround == false)
                {
                    Console.WriteLine($"{burnMessage}");
                    string[] options = { "Look around the libary.", "Turn back through the door.", "Inspect the Golden Container", "Open the Golden Container.", "Inspect the \"Works of Fiction\" shelf.", "Inspect the \"Natural Histories\" shelf." };
                    int currentAnswer = UtilityMethods.PromptAndValidateUserInput(options);
                    switch (currentAnswer)
                    {
                        case 1:
                            LookAroundLibary();
                            break;
                        case 2:
                            TurnAround();
                            break;
                        case 3:
                            InspectTheGoldenContainer();
                            break;
                        case 4:
                            OpenTheGoldenContainer();
                            break;
                        case 5:
                            InspectWorksOfFicton();
                            break;
                        case 6:
                            InspectNaturalHistories();
                            break;
                    }
                }
                else if (LibaryVaraibles.turnedAround == true)
                {
                    Console.WriteLine($"{burnMessage}");
                    string[] options = { "Look around the libary.", "Inspect the Golden Container", "Open the Golden Container.", "Inspect the \"Works of Fiction\" shelf.", "Inspect the \"Natural Histories\" shelf." };
                    int currentAnswer = UtilityMethods.PromptAndValidateUserInput(options);
                    switch (currentAnswer)
                    {
                        case 1:
                            LookAroundLibary();
                            break;
                        case 2:
                            InspectTheGoldenContainer();
                            break;
                        case 3:
                            OpenTheGoldenContainer();
                            break;
                        case 4:
                            InspectWorksOfFicton();
                            break;
                        case 5:
                            InspectNaturalHistories();
                            break;
                    }
                }
            }
        }
    }
    static void InspectWorksOfFicton()
    {
        // Text for inspecting the Fiction Book Shelf for the first time only else smaller text written. 
        if (LibaryVaraibles.inspectedWorksOfFiction == false)
        {
            LibaryVaraibles.inspectedWorksOfFiction = true;
            Console.WriteLine($"You look over at the left side shelf and see multiple works. You notice many of the books have decayed, whose covers are barely legible.\nHowever, a few books remain good quailty and stand out to you.\n{LibaryVaraibles.workOfFictionOne} by {LibaryVaraibles.workOfFictionOneAuthor}.\n{LibaryVaraibles.workOfFictionTwo} by {LibaryVaraibles.workOfFictionTwoAuthor}.\n{LibaryVaraibles.workOfFictionThree} by {LibaryVaraibles.workOfFictionThreeAuthor}.");
        }
        else if (LibaryVaraibles.inspectedWorksOfFiction == true)
        {
            Console.WriteLine("You look over again at the Works of Fiction shelf.");
        }

        // Ensures deduction is made only one time, once either shelf has been inspected after inspecting Golden Container.
        if (LibaryVaraibles.glassContainerInspected == true && LibaryVaraibles.bookAndGlassContainerConnectionMade == false)
        {
            LibaryVaraibles.bookAndGlassContainerConnectionMade = true;
            Console.WriteLine("You look at the books on the shelf and notice that they appear to have the same dimensions as the imprints on the Golden Containers base.");
        }

        // Each case in switch statement relates to choosing one of the books. The if ... else statements within the cases cover whether deduction has been made between Golden Container and the books,
        // as placing books is allowed with container having been inspected prior.
        string[] options = { $"Take a look at {LibaryVaraibles.workOfFictionOne} by {LibaryVaraibles.workOfFictionOneAuthor}.", $"Take a look at {LibaryVaraibles.workOfFictionTwo} by {LibaryVaraibles.workOfFictionTwoAuthor}.", $"Take a look at {LibaryVaraibles.workOfFictionThree} by {LibaryVaraibles.workOfFictionThreeAuthor}.\n" };
        int currentAnswer = UtilityMethods.PromptAndValidateUserInput(options);
        switch (currentAnswer)
        {
            case 1:
                if (LibaryVaraibles.glassContainerInspected == false)
                {
                    Console.WriteLine($"You lift up {LibaryVaraibles.workOfFictionOne} and sift through the pages. It appears to be just an ordinary book. You place it back down.");
                    break;
                }
                else
                {
                    Console.WriteLine($"You lift up {LibaryVaraibles.workOfFictionOne}.");
                    string[] subOptions = { "Place the book into the Golden Container Inprint.", "Place the book back down." };
                    int subCurrentAnswer = UtilityMethods.PromptAndValidateUserInput(subOptions);
                    switch (subCurrentAnswer)
                    {
                        case 1:
                            Console.WriteLine($"You place {LibaryVaraibles.workOfFictionOne} onto the left side of the Golden Container's inprint.");
                            LibaryVaraibles.correctLibaryBooks[0] = false;
                            break;
                        case 2:
                            Console.WriteLine("You place the book back onto the shelf.");
                            break;
                    }
                    break;
                }
            case 2:
                if (LibaryVaraibles.glassContainerInspected == false)
                {
                    Console.WriteLine($"You lift up {LibaryVaraibles.workOfFictionTwo} and sift through the pages. It appears to be just an ordinary book. You place it back down.");
                    break;
                }
                else
                {
                    Console.WriteLine($"You lift up {LibaryVaraibles.workOfFictionTwo}.");
                    string[] subOptions = { "Place the book into the Golden Container Inprint.", "Place the book back down." };
                    int subCurrentAnswer = UtilityMethods.PromptAndValidateUserInput(subOptions);
                    switch (subCurrentAnswer)
                    {
                        case 1:
                            Console.WriteLine($"You place {LibaryVaraibles.workOfFictionTwo} onto the left side of the Golden Container's inprint.");
                            LibaryVaraibles.correctLibaryBooks[0] = true;
                            break;
                        case 2:
                            Console.WriteLine("You place the book back onto the shelf.");
                            break;
                    }
                    break;
                }
            case 3:
                if (LibaryVaraibles.glassContainerInspected == false)
                {
                    Console.WriteLine($"You lift up {LibaryVaraibles.workOfFictionThree} and sift through the pages. It appears to be just an ordinary book. You place it back down.");
                    break;
                }
                else
                {
                    Console.WriteLine($"You lift up {LibaryVaraibles.workOfFictionThree}");
                    string[] subOptions = { "Place the book into the Golden Container Inprint.", "Place the book back down." };
                    int subCurrentAnswer = UtilityMethods.PromptAndValidateUserInput(subOptions);
                    switch (subCurrentAnswer)
                    {
                        case 1:
                            Console.WriteLine($"You place {LibaryVaraibles.workOfFictionThree} onto the left side of the Golden Container's inprint.");
                            LibaryVaraibles.correctLibaryBooks[0] = false;
                            break;
                        case 2:
                            Console.WriteLine("You place the book back onto the shelf.");
                            break;
                    }
                    break;
                }
        }
        // Control Flow follows back into room options once a decision has been made with the books.
        // Options available depend on whether have turned around or not.
        if (LibaryVaraibles.turnedAround == false)
        {
            Console.WriteLine("You return to the centre of the room.");
            string[] options2 = { "Look around the libary.", "Turn back through the door.", "Inspect the Golden Container", "Open the Golden Container.", "Inspect the \"Works of Fiction\" shelf.", "Inspect the \"Natural Histories\" shelf." };
            int currentAnswer2 = UtilityMethods.PromptAndValidateUserInput(options2);
            switch (currentAnswer2)
            {
                case 1:
                    LookAroundLibary();
                    break;
                case 2:
                    TurnAround();
                    break;
                case 3:
                    InspectTheGoldenContainer();
                    break;
                case 4:
                    OpenTheGoldenContainer();
                    break;
                case 5:
                    InspectWorksOfFicton();
                    break;
                case 6:
                    InspectNaturalHistories();
                    break;
            }
        }
        else if (LibaryVaraibles.turnedAround == true)
        {
            Console.WriteLine("You return to the centre of the room.");
            string[] options3 = { "Look around the libary.", "Inspect the Golden Container", "Open the Golden Container.", "Inspect the \"Works of Fiction\" shelf.", "Inspect the \"Natural Histories\" shelf." };
            int currentAnswer3 = UtilityMethods.PromptAndValidateUserInput(options3);
            switch (currentAnswer3)
            {
                case 1:
                    LookAroundLibary();
                    break;
                case 2:
                    InspectTheGoldenContainer();
                    break;
                case 3:
                    OpenTheGoldenContainer();
                    break;
                case 4:
                    InspectWorksOfFicton();
                    break;
                case 5:
                    InspectNaturalHistories();
                    break;
            }
        }
    }
    static void InspectNaturalHistories()
    {
        // Text for inspecting the Non-Fiction Book Shelf for the first time only else smaller text written. 
        if (LibaryVaraibles.inspectedNonFictionalWorks == false)
        {
            LibaryVaraibles.inspectedNonFictionalWorks = true;
            Console.WriteLine($"You look over at the right side shelf. It is quite barren and few works remain.\nThose works that remain are of dubious quailty, but some can be still be read albeit with some difficulty.\n{LibaryVaraibles.nonFictionOne} by {LibaryVaraibles.nonFictionOneAuthor}.\n{LibaryVaraibles.nonFictionTwo} by {LibaryVaraibles.nonFictionTwoAuthor}.\n{LibaryVaraibles.nonFictionThree} by {LibaryVaraibles.nonFictionThreeAuthor}.");
        }
        else if (LibaryVaraibles.inspectedNonFictionalWorks == true)
        {
            Console.WriteLine("You look over again at the Natural Histories shelf.");
        }

        // Ensures deduction is made only one time, once either shelf has been inspected after inspecting Golden Container.
        if (LibaryVaraibles.glassContainerInspected == true && LibaryVaraibles.bookAndGlassContainerConnectionMade == false)
        {
            LibaryVaraibles.bookAndGlassContainerConnectionMade = true;
            Console.WriteLine("You look at the books on the shelf and notice that they appear to have the same dimensions as the imprints on the Golden Containers base.");
        }

        // Each case in switch statement relates to choosing one of the books. The if ... else statements within the cases cover whether deduction has been made between Golden Container and the books,
        // as placing books is allowed with container having been inspected prior.
        string[] options = { $"Take a look at {LibaryVaraibles.nonFictionOne} by {LibaryVaraibles.nonFictionOneAuthor}.", $"Take a look at {LibaryVaraibles.nonFictionTwo} by {LibaryVaraibles.nonFictionTwoAuthor}.", $"Take a look at {LibaryVaraibles.nonFictionThree} by {LibaryVaraibles.nonFictionThreeAuthor}.\n" };
        int currentAnswer = UtilityMethods.PromptAndValidateUserInput(options);
        switch (currentAnswer)
        {
            case 1:
                if (LibaryVaraibles.glassContainerInspected == false)
                {
                    Console.WriteLine($"You lift up {LibaryVaraibles.nonFictionOne} and sift through the pages. It appears to be just an ordinary book. You place it back down.");
                    break;
                }
                else
                {
                    Console.WriteLine($"You lift up {LibaryVaraibles.nonFictionOne}.");
                    string[] subOptions = { "Place the book into the Golden Container Inprint.", "Place the book back down." };
                    int subCurrentAnswer = UtilityMethods.PromptAndValidateUserInput(subOptions);
                    switch (subCurrentAnswer)
                    {
                        case 1:
                            Console.WriteLine($"You place {LibaryVaraibles.nonFictionOne} onto the right side of the Golden Container's inprint.");
                            LibaryVaraibles.correctLibaryBooks[1] = false;
                            break;
                        case 2:
                            Console.WriteLine("You place the book back onto the shelf.");
                            break;
                    }
                    break;
                }
            case 2:
                if (LibaryVaraibles.glassContainerInspected == false)
                {
                    Console.WriteLine($"You lift up {LibaryVaraibles.nonFictionTwo} and sift through the pages. It appears to be just an ordinary book. You place it back down.");
                    break;
                }
                else
                {
                    Console.WriteLine($"You lift up {LibaryVaraibles.nonFictionTwo}.");
                    string[] subOptions = { "Place the book into the Golden Container Inprint.", "Place the book back down." };
                    int subCurrentAnswer = UtilityMethods.PromptAndValidateUserInput(subOptions);
                    switch (subCurrentAnswer)
                    {
                        case 1:
                            Console.WriteLine($"You place {LibaryVaraibles.nonFictionTwo} onto the right side of the Golden Container's inprint.");
                            LibaryVaraibles.correctLibaryBooks[1] = false;
                            break;
                        case 2:
                            Console.WriteLine("You place the book back onto the shelf.");
                            break;
                    }
                    break;
                }
            case 3:
                if (LibaryVaraibles.glassContainerInspected == false)
                {
                    Console.WriteLine($"You lift up {LibaryVaraibles.nonFictionThree} and sift through the pages. It appears to be just an ordinary book. You place it back down.");
                    break;
                }
                else
                {
                    Console.WriteLine($"You lift up {LibaryVaraibles.nonFictionThree}");
                    string[] subOptions = { "Place the book into the Golden Container Inprint.", "Place the book back down." };
                    int subCurrentAnswer = UtilityMethods.PromptAndValidateUserInput(subOptions);
                    switch (subCurrentAnswer)
                    {
                        case 1:
                            Console.WriteLine($"You place {LibaryVaraibles.nonFictionThree} onto the right side of the Golden Container's inprint.");
                            LibaryVaraibles.correctLibaryBooks[1] = true;
                            break;
                        case 2:
                            Console.WriteLine("You place the book back onto the shelf.");
                            break;
                    }
                    break;
                }
        }

        // Control Flow follows back into room options once a decision has been made with the books.
        // Options available depend on whether have turned around or not.
        if (LibaryVaraibles.turnedAround == false)
        {
            Console.WriteLine("You return to the centre of the room.");
            string[] options2 = { "Look around the libary.", "Turn back through the door.", "Inspect the Golden Container", "Open the Golden Container.", "Inspect the \"Works of Fiction\" shelf.", "Inspect the \"Natural Histories\" shelf." };
            int currentAnswer2 = UtilityMethods.PromptAndValidateUserInput(options2);
            switch (currentAnswer2)
            {
                case 1:
                    LookAroundLibary();
                    break;
                case 2:
                    TurnAround();
                    break;
                case 3:
                    InspectTheGoldenContainer();
                    break;
                case 4:
                    OpenTheGoldenContainer();
                    break;
                case 5:
                    InspectWorksOfFicton();
                    break;
                case 6:
                    InspectNaturalHistories();
                    break;
            }
        }
        else if (LibaryVaraibles.turnedAround == true)
        {
            Console.WriteLine("You return to the centre of the room.");
            string[] options3 = { "Look around the libary.", "Inspect the Golden Container", "Open the Golden Container.", "Inspect the \"Works of Fiction\" shelf.", "Inspect the \"Natural Histories\" shelf." };
            int currentAnswer3 = UtilityMethods.PromptAndValidateUserInput(options3);
            switch (currentAnswer3)
            {
                case 1:
                    LookAroundLibary();
                    break;
                case 2:
                    InspectTheGoldenContainer();
                    break;
                case 3:
                    OpenTheGoldenContainer();
                    break;
                case 4:
                    InspectWorksOfFicton();
                    break;
                case 5:
                    InspectNaturalHistories();
                    break;
            }
        }
    }
    static void ReadTheScroll()
    {

    }
    static void PlaceTheScrollBackDown()
    {
        Console.WriteLine("You try and place down the scroll");
    }
}