// See https://aka.ms/new-console-template for more information
using GA_Class_ManjulaRajan;

public class program
{
    //Manjula Rajan
    //Guided Assignment: Class
    //02/22/2024


    static void Main(string[] args)
    {

        //Created Instance of Puppy

        Puppy puppy1 = new Puppy("Skye", 765, "Boarder Collie");
        Puppy puppy2 = new Puppy("Chase", 345, "Papillon");

        //Created Instance of Show host

        PawPatrol pawpatrol1 = new PawPatrol("Junior Rider", 3, "Boarder Collie");
        PawPatrol pawpatrol2 = new PawPatrol("Samuel", 4, "Dalmatian");

        //Print details of host and Puppy

        Console.WriteLine("Puppy 1;");
        puppy1.detail();

        Console.WriteLine("Puppy 2;");
        puppy2.detail();

        Console.WriteLine("Host 1;");
        pawpatrol1.detail();

        Console.WriteLine("Host 2;");
        pawpatrol2.detail();
    }
}


