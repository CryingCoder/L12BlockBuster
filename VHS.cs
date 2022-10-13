using L12BlockBuster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace L12BlockBuster
{
    public class VHS : Movie
    {

        //Properties
        public int CurrentScene { get; set; }

        
        //Constructor to call Movie Class and let it know we want to send it some parameters from VHS
        public VHS(string Title, GenreCategory Genre, int RunTime, List<string> Scenes) : base(Title, Genre, RunTime, Scenes) 
        { 
        }


        //A method that plays the scene at the CurrentScene and then increments CurrentScene
        //Because the Parent method is Abstract, this must be an override
        public override void Play()
        {
            for (int i = 0; i < Scenes.Count; i++)
            {
                CurrentScene++;

            }
            
        }



        //A method that returns nothing and sets CurrentScene to 0
        public void Rewind()
        {
            CurrentScene = 0;
        }

    }
}


/*Next Create a child class of Movie called VHS and code the following:
A property called CurrentScene 
A method called Play() that plays the scene at the CurrentScene and then increments CurrentScene . 
A method called Rewind() that returns nothing and sets CurrentScene to 0.*/