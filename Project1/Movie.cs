using System;
using System.IO;

namespace Text
{
    class Movie
    {
        private string title;
        private string director;
        private int year;
            
        public string Title { get => title; set => title = value; }
        public string Director { get => director; set => director = value; }
        public int Year { get => year; set => year = value; }

        public Movie()
        {
            Title = "Title";
            Director = "John Doe";
            Year = 1900;
        }

        public void DisplayInformation()
        {
            Console.WriteLine("Tytul: {0}", Title);
            Console.WriteLine("Rezyser: {0}", Director);
            Console.WriteLine("Rok: {0}", Year);
            Console.WriteLine("----------------------------");
        }
    }
}
