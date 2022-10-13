using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L12BlockBuster
{
    public abstract class Movie
    {

        //Class Properties
        public string Title { get; set; }

        public GenreCategory Genre { get; set; }
        public int RunTime { get; set; }

        public List<string> Scenes  { get; set; }

        //List<Movie> Movies { get; set; } idk

        public Movie(string Title, GenreCategory Genre, int RunTime, List<string> Scenes)
        {
            Title = Title;
            Genre = Genre;
            RunTime = RunTime;
            Scenes = Scenes;
        }



        //Enumuration for movie genres
        public enum GenreCategory
        {
            Drama,
            Comedy,
            Horror,
            Romance,
            Action
        }



        //Virtual method that prints all properties in the class to the console save for the scenes
        public virtual void PrintInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Genre: {Genre}");
            Console.WriteLine($"Run time: {RunTime}");
        }



        //Virtual Method that prints all the scenes in the list along with their index. 
        //I have no clue how the indexing works. I had to look it up, but holy shit is that annoying
        public virtual void PrintScenes(string scene)
        {
            for (int i = 0; i < Scenes.Count; i++)
            {
                Console.WriteLine($"Scene {i}: {Scenes[i]}");
            }
        }



        //Abstract method - Nothing to return
        public abstract void Play();


    }
}





/*Create an abstract Movie class with the following: 
A property for Title that’s a string 

A property for Category that’s of Enum Genre - if we haven’t covered this yet, just use a string 

An int property for RunTime (in minutes) 

A list of strings called Scenes

A virtual method called PrintInfo() that prints all properties in the class to the console save for the scenes

A method called PrintScenes() that prints all the scenes in the list along with their index

An abstract method with no return type called Play() (If we haven’t covered abstract yet, just make this method virtual instead) */