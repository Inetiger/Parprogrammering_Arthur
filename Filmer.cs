using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parprogrammering_Arthur
{
    internal class Filmer
    {
        private string _title;
        private int _releaseYear;
        private string _description;
        private string _director;
        private string _actors;

        public Filmer(string title, int releaseYear, string description, string director, string actors)
        {
            _title = title;
            _releaseYear = releaseYear;
            _description = description;
            _director = director;
            _actors = actors;
        }

        public void PrintInfoOnMovie()
        {
            Console.WriteLine($"Tittle: {_title}\nRelease Year: {_releaseYear}\nDescription: {_description}\nDirector: {_director}\nActors: {_actors}");
        }

        public string PrintTitle()
        {
            return _title;
        }
    }
}
