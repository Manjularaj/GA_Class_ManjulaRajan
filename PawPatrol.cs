using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_Class_ManjulaRajan
{
    internal class PawPatrol
    {
        //Properties and data types 
        //Shows were not given access to set since shows are arranged based on availability of dogs and hosts which is highly sensitive if its changed by others accidently.
        public string Name { get; set; }
        public int Shows { get; }
        public string Breed { get; set; }

        public PawPatrol(string name, int shows, string breed)
        {
            Name = name;
            Shows = shows;
            Breed = breed;
        }
        public void detail()
        {
            Console.WriteLine($"Name - {Name}, Shows - {Shows}, Breed - {Breed}");
        }
    }
}
