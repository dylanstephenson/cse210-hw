// Added creativity by making the number of words that are hidden each time user hits enter different. Also added a list of scripture objects so that a random scripture is displayed when the program is run.

using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> indexes = new List<int>();
        for (int i = 0; i < 5; i++)
        {
            indexes.Add(i+1);
        }
        List<Scripture> scriptureList = new List<Scripture>();

        Reference scripRef1 = new Reference("Omni", 1, 26);
        Reference scripRef2 = new Reference("John", 3, 16, 17);
        Reference scripRef3 = new Reference("Moroni", 10, 32);
        Reference scripRef4 = new Reference("Romans", 12, 1);
        Reference scripRef5 = new Reference("D&C", 88, 67);

        Scripture scripture1 = new Scripture(scripRef1, "And now, my beloved brethren, I would that ye should come unto Christ, who is the Holy One of Israel, and partake of his salvation, and the power of his redemption. Yea, come unto him, and offer your whole souls as an offering unto him, and continue in fasting and praying, and endure to the end; and as the Lord liveth ye will be saved.");
        Scripture scripture2 = new Scripture(scripRef2, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life. \n\nFor God sent not his Son into the world to condemn the world; but that the world through him might be saved.");
        Scripture scripture3 = new Scripture(scripRef3, "Yea, come unto Christ, and be perfected in him, and deny yourselves of all ungodliness; and if ye shall deny yourselves of all ungodliness, and love God with all your might, mind and strength, then is his grace sufficient for you, that by his grace ye may be perfect in Christ; and if by the grace of God ye are perfect in Christ, ye can in nowise deny the power of God.");
        Scripture scripture4 = new Scripture(scripRef4, "I beseech you therefore, brethren, by the mercies of God, that ye present your bodies a living sacrifice, holy, acceptable unto God, which is your reasonable service.");
        Scripture scripture5 = new Scripture(scripRef5, "And if your eye be single to my glory, your whole bodies shall be filled with light, and there shall be no darkness in you; and that body which is filled with light comprehendeth all things.");

        scriptureList.Add(scripture1);
        scriptureList.Add(scripture2);
        scriptureList.Add(scripture3);
        scriptureList.Add(scripture4);
        scriptureList.Add(scripture5);

        Random random = new Random();
        int scripIndex = random.Next(scriptureList.Count);
        Scripture randomScripture = scriptureList[scripIndex];

        bool completelyHidden = randomScripture.IsCompletelyHidden();

        Console.WriteLine(randomScripture.GetDisplayText());
        Console.Write("Click 'Enter' to hide words, or type 'quit' to exit the program: ");
        string userInp = Console.ReadLine();
        Console.Clear();

        while (userInp != "quit")
        {
            Random r = new Random();
            int hideWords = random.Next(indexes.Count);
            randomScripture.HideRandomWords(indexes[hideWords]);

            Console.WriteLine(randomScripture.GetDisplayText());

            completelyHidden = randomScripture.IsCompletelyHidden();

            if (completelyHidden == true)
            {
                Console.Clear();
                break;
            }
            Console.Write("Click 'Enter' to hide words, or type 'quit' to exit the program: ");
            userInp = Console.ReadLine();
            Console.Clear();
        }
    }
}