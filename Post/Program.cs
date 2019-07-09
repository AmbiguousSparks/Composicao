using PostProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostProject
{
    class Program
    {
        static void Main ( string[] args )
        {
            Comment c1 = new Comment("Have a nice trip!");
            Comment c2 = new Comment("Wow that's awesome!");

            Post p1 = new Post(
                DateTime.Now,
                "Traveling to New Zealand",
                "I'm going to visit this wonderful country",
                12);
            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment("Good night");
            Comment c4 = new Comment("May the Force be with you!");

            Post p2 = new Post(
                DateTime.Now,
                "Good night guys!",
                "See you tomorrow",
                5);
            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine("\n" + p2);
        }
    }
}
