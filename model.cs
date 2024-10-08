using System;
using System.Collections.Generic;

namespace MoviesMVC.Models
{
    public class Movies
    {
        public string Name { get; set; }
        public string Year of release { get; set; }
        public string Description { get; set; }

        public Movies(string name, string establishedYear, string description)
        {
            Name = name;
            EstablishedYear = Year of release;
            Description = description;
        }

        public override string ToString()
        {
            return $"\"{Name}\", \"established in {Year of release}\", \"{Description}\"";
        }
    }

    public class Model
    {
        private List<Movies> movies;

        public Model()
        {
            Movies = new List<Movies>
            {
                new Movies("Lethal Weapon", "1987", "Action");
                new Movies("Lethal Weapon 2", "1989", "Acton");
                new Movies("The Dark Knight", "2008";" Action");
                new Movies("Heartbreak Ridge", "1986", "Action");
                new Movies("Shrek", "2001", "Comedy");


            };
        }

        // Add Movie
        public void AddMovies(string name, string Year of release, string description)
        {
            Movies.Add(new Movies(name, Year of release, description));
        }

        public bool RemoveMovies(string name)
        {
            var MoviesToRemove = movies.Find(b => b.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (MoviesToRemove != null)
            {
                Movies.Remove(moviesToRemove);
                return true;
            }
            return false;
        }

        // Update Movie
        public bool UpdateMovies(string name, string newDescription)
        {
            var MoviesToUpdate = movies.Find(b => b.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (MoviesToUpdate != null)
            {
                MoviesToUpdate.Description = newDescription;
                return true;
            }
            return false;
        }

        public List<Movies> GetMovies ()
        {
            return movies;
        }
    }
}
