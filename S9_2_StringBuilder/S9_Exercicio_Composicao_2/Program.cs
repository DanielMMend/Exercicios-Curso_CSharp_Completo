using System;
using System.Globalization;
using S9_Exercicio_Composicao_2.Entities;

namespace S9_Exercicio_Composicao_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Post p1 = new Post();
            p1.Moment = DateTime.ParseExact("21/06/2018 13:05:44", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            p1.Title = "Traveling to New Zealand";
            p1.Content = "I'm going to visit this wonderful country!";
            p1.Likes = 12;
            Comment c1 = new Comment("Have a nice trip");
            Comment c2 = new Comment("Wow that's awesome!");
            p1.Comments.Add(c1);
            p1.Comments.Add(c2);

            Post p2 = new Post();
            p2.Moment = DateTime.ParseExact("28/07/2018 23:14:19", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            p2.Title = "Good night guys";
            p2.Content = "See you tomorrow";
            p2.Likes = 5;
            Comment c3 = new Comment("Good night");
            Comment c4 = new Comment("May the Force be with you");
            p2.Comments.Add(c3);
            p2.Comments.Add(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
