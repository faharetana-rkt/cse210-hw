using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videoList = new List<Video>();

        Video aramsamsam = new Video("Aramsamsam", "LooLoo Kids", 300);
        videoList.Add(aramsamsam);
        Comment aramComment1 = new Comment("FluffyDad", "My kids adore this video");
        aramsamsam._comments.Add(aramComment1);
        Comment aramComment2 = new Comment("Mommy228", "This video helps my kids exercise in the morning");
        aramsamsam._comments.Add(aramComment2);
        Comment aramComment3 = new Comment("July", "I am a 12 year old kid and I still vibe to this nursery song");
        aramsamsam._comments.Add(aramComment3);

        Video ritmo = new Video("RITMO (ft. J Balvin)", "BlackEyedPeas", 219);
        videoList.Add(ritmo);
        Comment ritmoComment1 = new Comment("Suavé", "This is a nice take on the classic song this is the rythm of the night");
        ritmo._comments.Add(ritmoComment1);
        Comment ritmoComment2 = new Comment("MovieAddict123", "If I'm not mistaken, this is the OST for the movie Bad Boys 4 Life");
        ritmo._comments.Add(ritmoComment2);
        Comment ritmoComment3 = new Comment("Allie", "This is seriously a BOP!!!!");
        ritmo._comments.Add(ritmoComment3);
        Comment ritmoComment4 = new Comment("John McArthur", "Listening on the highway atm.");
        ritmo._comments.Add(ritmoComment4);

        Video motivational = new Video("How to stay motivated?", "Jane Lee", 900);
        videoList.Add(motivational);
        Comment motivationalComment1 = new Comment("Lenny", "It helped me finish my studies, thank you very much.");
        motivational._comments.Add(motivationalComment1);
        Comment motivationalComment2 = new Comment("Jill", "Can't wait for the part 2 of this video!");
        motivational._comments.Add(motivationalComment2);
        Comment motivationalComment3 = new Comment("Clay", "Will there be another motivational video soon?");
        motivational._comments.Add(motivationalComment3);

        foreach (Video video in videoList)
        {
            Console.WriteLine(video.ToStr());
            foreach (Comment comment in video._comments)
            {
                Console.WriteLine($"  {comment.ToStr()}");
            }
            Console.WriteLine();
        }
    }
}