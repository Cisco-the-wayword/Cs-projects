using System;

namespace StackOverflowPost
{
    class Post
    {
        private int _votes = 0;
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDateTime { get; }

        public Post(string title, string description)
        {
            Title = title;
            Description = description;
            CreatedDateTime = DateTime.Now;
        }

        public void UpVote()
        {
            _votes++;
        }

        public void DownVote()
        {
            _votes--;
        }

        public int GetVotes()
        {
            return _votes;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a new post
            Post post = new Post("C# is awesome", "Check out my C# code!");

            // Up-vote and down-vote the post
            post.UpVote();
            post.UpVote();
            post.DownVote();

            // Display the current vote value
            Console.WriteLine("Current votes: " + post.GetVotes());
        }
    }
}
