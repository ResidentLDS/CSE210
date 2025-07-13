using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videoList = new List<Video>();
        Comment comment_1 = new Comment("StevenHe", "The most creative wave to write off a blueberry pie.");
        Comment comment_2 = new Comment("kylepool5140", "My super power? The power to read my own mind.");
        Comment comment_3 = new Comment("CheeseGrilled", "My superpower is forgetting everything I've just been told but remembering that cringe moment from 10 years ago in 4k UHD 60fps");
        Video video_1 = new Video("when your superpower is really lame", "Daniel Thrasher", 41, comment_1, comment_2, comment_3);

        comment_1 = new Comment("leightonpetty4817", "We got a \"This Game Blows\" joke, that makes me so happy");
        comment_2 = new Comment("Segastar1", "Liquidate the company is still one of my favorite endings in a Scott the Woz episode");
        comment_3 = new Comment("Orangienblue", "Scott: uploads on a Friday\nMe: is that a threat?");
        Video video_2 = new Video("Wii Play Motion | Eh, Why? - Scott The Woz", "Scott The Woz", 708, comment_1, comment_2, comment_3); //So I've been doing actual videos, this is how it's set up, look it up if you don't believe me

        comment_1 = new Comment("Merritt1254", "A moving picture you can hear!? Technology is truly amazing");
        comment_2 = new Comment("tylergaming80612", "I like how Mark acts like he isn't allowed to change the decor once he chooses it");
        comment_3 = new Comment("echoes_", "Man, I'm glad this is the FIRST upload of this video with no audio issues!");
        Video video_3 = new Video("THERE WAS NEVER A PROBLEM WITH THIS VIDEO | Supermarket Simulator - Part 5", "Markiplier", 2897, comment_1, comment_2, comment_3);

        videoList.Add(video_1);
        videoList.Add(video_2);
        videoList.Add(video_3);
        foreach (Video g in videoList)
        {
            g.PrintVideos();
            Console.WriteLine("\n");
        }
    }
}