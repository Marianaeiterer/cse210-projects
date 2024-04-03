using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Anna of the North - Lovers", "Anna of the North", 219);
        Comment comment1 = new("Mariana O.", "This music remindes me the movie!");
        Comment comment2 = new("Sara V.", "I can't stop listening to this!!");
        Comment comment3 = new("Tom D.", "Really good song!");
        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);

        Video video2 = new Video("Lana Del Rey - Margaret (Audio) ft. Bleachers", "Lana Del Rey", 339);
        Comment comment4 = new Comment("Brianna John", "So beatiful!");
        Comment comment5 = new Comment("Joanna", "The story behind the music is amazing!");
        Comment comment6 = new Comment("Samuel", "Really pretty the lyrics");
        Comment comment7 = new Comment("Ryan John", "Calm song");
        video2.AddComment(comment4);
        video2.AddComment(comment5);
        video2.AddComment(comment6);
        video2.AddComment(comment7);

        Video video3 = new Video("Adele - Love Is A Game (Official Lyric Video)", "Adele", 403);
        Comment comment8 = new Comment("Sabrina", "I love Adele!");
        Comment comment9 = new Comment("Marian", "This song always makes me cry");
        Comment comment10 = new Comment("Joan", "What a voice!");
        video3.AddComment(comment8);
        video3.AddComment(comment9);
        video3.AddComment(comment10);

        Video video4 = new Video("Adele - Hello (Official Music Video)", "Adele", 366);
        Comment comment11 = new Comment("Joyce", "Adele is my favorite singer!");
        Comment comment12 = new Comment("Julian", "Love this song!");
        Comment comment13 = new Comment("Joan", "Her concert is just amazing!!!!");
        video4.AddComment(comment11);
        video4.AddComment(comment12);
        video4.AddComment(comment13);

        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        foreach (Video video in videos)
        {
            video.DisplayVideoDetails();
            
        }

    }
}