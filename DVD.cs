using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L12BlockBuster
{
    public class DVD : Movie
    {
        //Properties
        string PrintScenes { get; set; }


        //Constructor to call Movie Class and let it know we want to send it some parameters from VHS
        public DVD(string Title, GenreCategory Genre, int RunTime, List<string> Scenes) : base(Title, Genre, RunTime, Scenes)
        {
        }
        public override void Play()
        {
            Console.WriteLine("What Scene would you like to watch?");
            for (int i = 0; i < Scenes.Count; i++)
            {
                Console.WriteLine(PrintScenes);
            }
            string choice = Console.ReadLine();
            PrintScenes(choice);
        }

    }
}


/*Create a child of Movie named DVD with the following code: 
A method called Play() that takes no parameters and is void 
that will ask the user what scene they’d like to watch, 
print all the available scenes, 
and allow the user to select a scene from the list and print it out.*/