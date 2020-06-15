using System;

namespace StackOverflowPost
{
    public class Post
    {
       
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        public int UpvoteCount { get; private set; }
        public int DownvoteCount { get; private set; }

        public void UpVote()
        {
            UpvoteCount++;
        }

        public void DownVote()
        {
            DownvoteCount++;
        }

        public int score()
        {
            return UpvoteCount - DownvoteCount;
        }


    }
}
