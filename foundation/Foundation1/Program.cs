using System;

class Program
{
    static void Main(string[] args)
    {
        Video cover = new Video("Taylor Swift - Seven (Cover by Camila)", "Camila Moya", 210);
        cover.addComment(new Comment("mikey02", "love it!!"));
        cover.addComment(new Comment("Anne Marie", "So good! Please sing Guilty as sin!!"));
        cover.addComment(new Comment("fuzzyBear", "good job, I love this song"));
        cover.addComment(new Comment("Claudio", "you should sing close to you by the carpenters"));

        Video vlog = new Video("paris vlog (i want to move here)", "Emma Chamberlain", 480);
        vlog.addComment(new Comment("mikey02", "i went there 2 months ago :D"));
        vlog.addComment(new Comment("starboy", "i'm glad you had fun!!"));
        vlog.addComment(new Comment("Camila Moya", "how long are you staying? you should go to the louvre"));

        Video essay = new Video("Katniss Was NEVER A REBEL", "MoviesAreArt", 1200);
        essay.addComment(new Comment("mikey02", "this was such a well made video!"));
        essay.addComment(new Comment("EVERLARK_FAN", "I agree, that's what makes the story so powerful, she's just a girl"));
        essay.addComment(new Comment("MoviesGo", "i enjoyed watching!"));
        essay.addComment(new Comment("jinx", "great video essay!"));

        Video recipe = new Video("The Fudgiest Cocoa Powder Gluten Free Brownie", "Gluten Free Baking", 600);
        recipe.addComment(new Comment("Violeta Aprende", "I made it and it's the best!!!"));
        recipe.addComment(new Comment("mikey02", "looks amazing! Thanks for the video"));
        recipe.addComment(new Comment("rose miller", "these are actually so good! definitely making them again"));

        List<Video> videoList = new List<Video>();
        videoList.Add(cover);
        videoList.Add(vlog);
        videoList.Add(essay);
        videoList.Add(recipe);

        foreach (Video video in videoList)
        {
            Console.WriteLine($"\nTitle: {video.getTitle()}");
            Console.WriteLine($"Author: {video.getAuthor()}");
            Console.WriteLine($"Length (in seconds): {video.getLength()}");
            Console.WriteLine($"Number of comments: {video.getCommentNumber()}");
            foreach (Comment comment in video.getComments())
            {
                Console.WriteLine($"--{comment.getPersonName()}: {comment.getCommentText()}");
            }
        }
    }
}