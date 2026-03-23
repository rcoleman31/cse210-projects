using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection.PortableExecutable;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video v1 = new Video("How to Study Better", "Rachel", 300);
        v1.AddComment(new Comment("John", "This helped a lot!"));
        v1.AddComment(new Comment("Emily", "Great tips!"));
        v1.AddComment(new Comment("Chris", "I will try this."));
        videos.Add(v1);

        // Video 2
        Video v2 = new Video("Morning Routine", "Sarah", 200);
        v2.AddComment(new Comment("Mike", "So motivating!"));
        v2.AddComment(new Comment("Anna", "I love this!"));
        v2.AddComment(new Comment("Luke", "Very helpful."));
        videos.Add(v2);

        // Video 3
        Video v3 = new Video("Workout Basics", "Jake", 400);
        v3.AddComment(new Comment("Tom", "Nice workout."));
        v3.AddComment(new Comment("Lily", "I'm sore already lol"));
        v3.AddComment(new Comment("Ben", "Good explanation."));
        videos.Add(v3);

        // Display all videos
        foreach (Video v in videos)
        {
            v.DisplayVideo();
        }
    }
}