using System;

namespace CSharpIntermediate
{
    public class Post
    {
        public string Title { get; }
        public string Description { get; set; }
        public int VoteValue { get; private set; }
        public DateTime TimeCreated { get; }

        public Post(string title, string description)
        {
            this.Title = title;
            this.Description = description;
            this.TimeCreated = DateTime.Now;
            this.VoteValue = 0;     
        }

        public void UpVote()
        {
            VoteValue++;
        }

        public void DownVote()
        {
            VoteValue--;
        }
    }
}
