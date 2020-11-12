using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace ChallengeObject
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Console.WriteLine("Welcome to the Movie List Application !");
            Console.WriteLine();
            //Console.ReadKey()
            //string strCategory = Console.ReadLine();

            Console.Write(" Select a number in the fallowing  category in \n 1 : Drama \n "+"2 : Scifi\n "+"3 : Animate\n");
            int strInput = int.Parse(Console.ReadLine());
           
        }

        private static List<Movie> MoviesoftheDay()
        {
            List<Movie> theGener = new List<Movie>();

            theGener.Add(new Movie("Drama", "freddie mercury"));
            theGener.Add(new Movie("Drama", "freddie mercury"));
            theGener.Add(new Movie("Scifi", "Back To The Future."));
            theGener.Add(new Movie("Scifi", "Blade Runner."));
            theGener.Add(new Movie("Horror", "A Quiet Place"));
            theGener.Add(new Movie("Horror", "Paranormal Activity"));
            theGener.Add(new Movie("Animated", "Nightmare Before Christmas"));
            theGener.Add(new Movie("Animate", "Chicken Run"));
            theGener.Add(new Movie("Horror", "chucky "));
            theGener.Add(new Movie("Drama", "Black Panther"));

            return theGener;

        }

       

    }

    public class Movie
        {
               

            public Movie(string theGener, string theTitle)
            {
                _theGener = theGener;
                _theTitle = theTitle;
            }

            private string _theTitle;

            public string GetTitle()
            {
                return _theTitle;
            }

            private string _theGener;

            public string GetGener()
            {
                return _theGener;
            }

        };          

}
