using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Learning C#", "Emmanuel", 300);
        video1.AddComment(new Comment("John", "Great video!"));
        video1.AddComment(new Comment("Mary", "I learned something new."));
        video1.AddComment(new Comment("David", "Keep it up!"));

        Video video2 = new Video("Introduction to Python", "Peter", 450);
        video2.AddComment(new Comment("Sarah", "Very helpful."));
        video2.AddComment(new Comment("James", "I love Python."));
        video2.AddComment(new Comment("Grace", "Thanks for sharing."));

        Video video3 = new Video("How the Internet Works", "Daniel", 600);
        video3.AddComment(new Comment("Michael", "This was interesting."));
        video3.AddComment(new Comment("Paul", "Great explanation."));
        video3.AddComment(new Comment("Esther", "I understand it better now."));

        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("Title: " + video.GetTitle());
            Console.WriteLine("Author: " + video.GetAuthor());
            Console.WriteLine("Length: " + video.GetLength() + " seconds");
            Console.WriteLine("Number of comments: " + video.GetCommentCount());
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine(
                    comment.GetCommenterName() + ": " + comment.GetText()
                );
            }

            Console.WriteLine();
        }
    }
}