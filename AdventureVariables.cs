namespace adventureNovel;

class PlayerVaraibles
{
    public static bool smallRockTaken = false;
    public static bool burnedHands = false;
}

class CaveVaraibles
{
    public static bool caveKeyFound = false;
    public static int doorKnockedCount = 0;
    public static bool lockInspected = false;
    public static bool doorUnlocked = false;
    public static bool doorMonsterAnnoyed = false;
    public static int timesLookedAroundCave = 0;
}

class LibaryVaraibles
{
    public static bool glassContainerInspected = false;
    public static bool[] correctLibaryBooks = { false, false };
    public static int timesBurned = 0;
    public static bool turnedAround = false;
    public static bool lookedAround = false;
    public static bool bookAndGlassContainerConnectionMade = false;
    public static bool inspectedWorksOfFiction = false;
    public static bool inspectedNonFictionalWorks = false;

    public static string workOfFictionOne = "\"The Knightly Tales From Under The Silver Sky\"";
    public static string workOfFictionOneAuthor = "Ser Reginald Peckham";
    public static string workOfFictionTwo = "\"By the Emerald Sea and Golden Sky\"";
    public static string workOfFictionTwoAuthor = "Agnus le Boiteux";
    public static string workOfFictionThree = "\"Machinations of The Iron Lady\"";
    public static string workOfFictionThreeAuthor = "David Lee";

    public static string nonFictionOne = "\"Crossing the Cosmic Realms - A Study On Non-Domestic Metals.\"";
    public static string nonFictionOneAuthor = "Irene Whitsworth and Christian Pickens";
    public static string nonFictionTwo = "\"\"";
    public static string nonFictionTwoAuthor = "";
    public static string nonFictionThree = "\"From Carbon To Diamonds, From Iron to Gold - Study of the Formation of Precious Gem and Metals.\"";
    public static string nonFictionThreeAuthor = "Danny Hyoung PHD";
}