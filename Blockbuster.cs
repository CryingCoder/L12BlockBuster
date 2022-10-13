using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L12BlockBuster
{
    public class Blockbuster
    {
        public List<Movie> Movies { get; set; }

        public void PrintMovies()
        {
            for (int i = 0; i < Movies.Count; i++)
            {
                Console.WriteLine($"Movie {i}: {Movies[i]}");
            }
        }

        public void CheckOut()
        {

        }

    }
}


/*Lastly, create a class named Blockbuster that contains the following code: 
Member variable called List<Movie> Movies
Method called PrintMovies() - this will print all the movie titles in the Movies list along with their indexes.
Method called CheckOut() - this will call PrintMovies() and ask the user which movie they’d like to check out, 
get an index from the user, 
select a movie from the list 
and PrintInfo() on that movie. 
The method should return the Movie object selected by the user.*/