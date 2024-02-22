using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GA_Class_ManjulaRajan
{
    public class Puppy
    {
        //Properties and data types 
        public string Name { get; set; }
        public int Days { get; set; }
        public string Breed { get; set; }

        public Puppy(string name, int days, string breed)
        {
            Name = name;
            Days = days;
            Breed = breed;

        }

        public void detail()
        {
            Console.WriteLine($"Name - {Name}, Days - {Days}, Breed - {Breed}");
        }

        
    }
}
