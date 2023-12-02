using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videoList = new List<Video>();

        List<Comment> commentList1 = new List<Comment>();
        Comment aramComment1 = new Comment("FluffyDad", "My kids adore this video");
        commentList1.Add(aramComment1);
        Comment aramComment2 = new Comment("Mommy228", "This video helps my kids exercise in the morning");
        commentList1.Add(aramComment2);
        Comment aramComment3 = new Comment("July", "I am a 12 year old kid and I still vibe to this nursery song");
        commentList1.Add(aramComment3);

        Video aramsamsam = new Video("Aramsamsam", "LooLoo Kids", 300, commentList1);
        videoList.Add(aramsamsam);
        
        List<Comment> commentList2 = new List<Comment>();

        Comment ritmoComment1 = new Comment("Suavé", "This is a nice take on the classic song this is the rythm of the night");
        commentList2.Add(ritmoComment1);
        Comment ritmoComment2 = new Comment("MovieAddict123", "If I'm not mistaken, this is the OST for the movie Bad Boys 4 Life");
        commentList2.Add(ritmoComment2);
        Comment ritmoComment3 = new Comment("Allie", "This is seriously a BOP!!!!");
        commentList2.Add(ritmoComment3);
        Comment ritmoComment4 = new Comment("John McArthur", "Listening on the highway atm.");
        commentList2.Add(ritmoComment4);

        Video ritmo = new Video("RITMO (ft. J Balvin)", "BlackEyedPeas", 219, commentList2);
        videoList.Add(ritmo);
        
        List<Comment> commentList3 = new List<Comment>();

        Comment motivationalComment1 = new Comment("Lenny", "It helped me finish my studies, thank you very much.");
        commentList3.Add(motivationalComment1);
        Comment motivationalComment2 = new Comment("Jill", "Can't wait for the part 2 of this video!");
        commentList3.Add(motivationalComment2);
        Comment motivationalComment3 = new Comment("Clay", "Will there be another motivational video soon?");
        commentList3.Add(motivationalComment3);
        Video motivational = new Video("How to stay motivated?", "Jane Lee", 900, commentList3);
        videoList.Add(motivational);
        

        foreach (Video video in videoList)
        {
            Console.WriteLine(video.ToString());
            Console.WriteLine(video.GetComments());
            Console.WriteLine();
        }
    }
}