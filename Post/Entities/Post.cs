using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostProject.Entities
{
    class Post
    {
        public DateTime Moment { get; private set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public int Likes { get; private set; }

        public List<Comment> Comments { get; private set; }

        public Post ()
        {
            Comments = new List<Comment>();
        }

        public Post (DateTime moment, string title, string content, int likes) : this()
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void AddComment ( Comment comment )
        {
            Comments.Add(comment);
        }

        public void RemoveComment ( Comment comment )
        {
            Comments.Remove(comment);
        }

        public override string ToString ()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/mm/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("\nComments: ");

            foreach (Comment comment in Comments) 
            {
                sb.AppendLine(comment.Text);
            }

            return sb.ToString();
        }
    }
}
