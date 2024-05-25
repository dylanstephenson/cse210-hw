using System;

class Program
{
    static void Main(string[] args)
    {
        Comment comment1 = new Comment("Billy","This is so cool");
        Comment comment2 = new Comment("Shadow", "Good work! I subscribed to your channel");
        Comment comment3 = new Comment("coolguy", "I've seen better.");
        Comment comment4 = new Comment("Gordan Ramses", "Dude, your cooking skills are insane! Post more like this!");
        Comment comment5 = new Comment("user158372", "Check out my channel for easy and quick recipes!");
        Comment comment6 = new Comment("Don", "I like the part where you eat the food at the end.");
        Comment comment7 = new Comment("Friendly Guy", "This is the best cover of a song I've ever heard!");
        Comment comment8 = new Comment("BeethovenFriend", "Good attempt! I think it feels a little rushed");
        Comment comment9 = new Comment("AJ", "You should do Wonderwall next!");

        List<Comment> comments1 = new List<Comment>() {comment1, comment2, comment3};
        List<Comment> comments2 = new List<Comment>() {comment4, comment5, comment6};
        List<Comment> comments3 = new List<Comment>() {comment7, comment8, comment9};

        Video video1 = new Video("I made a boat out of random stuff I found in my grandma's attic", "Crafty Man", 600, comments1);
        Video video2 = new Video("How to Make Traditional Baba Ganoush", "Cook with Dave", 420, comments2);
        Video video3 = new Video("Champagne Supernova//Oasis Jazz Cover", "Make it Jazz", 240, comments3);

        List<Video> videos = new List<Video>(){video1, video2, video3};

        Console.WriteLine("");
        foreach (Video video in videos)
        {
            int commentNumber = video.NumberOfComments();
            Console.WriteLine($"Title: {video._title} - {video._length} seconds");
            Console.WriteLine($"By: {video._author}\n");
            Console.WriteLine($"Comments: {commentNumber}\n");
            foreach(Comment comment in video._comments)
            {
                Console.WriteLine($"--{comment._name}--");
                Console.WriteLine($"{comment._comment}\n");
            }
        }
    }
}