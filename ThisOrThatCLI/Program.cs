using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisOrThatCLI
{
    public class Program
    {

        public static DatabaseFile UpdateMovie(DatabaseFile db)
        {
            Console.WriteLine("=======================Update a Movie========================");
            Console.WriteLine("What movie do you want to update (enter exit to cancel)?");
            Console.Write("> ");

            string userInput = Console.ReadLine();

            if (userInput.Equals("exit"))
            {

            }
            else
            {
                Movie movie = db.FindMovieFromTitle(userInput);

                if(movie == null)
                {
                    Console.WriteLine($"Could not find the movie named {userInput}!");
                }
                else
                {
                    Console.WriteLine($"Movie, {movie.Title}, was found!");
                    Console.WriteLine("What property would you like to update?");
                    Console.WriteLine("What property would you like to update?");
                    Console.WriteLine("\t1. Title");
                    Console.WriteLine("\t2. Elo");

                    userInput = Console.ReadLine();

                    if (userInput.Equals("1"))
                    {

                    }
                    else if(userInput.Equals("2"))
                    {

                    }
                    else
                    {

                    }

                    

                }
            }
        }

        public static void DisplayHelp()
        {
            Console.WriteLine("=======================Help Menu========================");
            Console.WriteLine("h: Display Help Menu");
            Console.WriteLine("l: Display All Movies in Database");
            Console.WriteLine("d: Delete a Movie from Database");
            Console.WriteLine("i: Insert a New Movie into Database");
            Console.WriteLine("u: Update a Movie in the Database");
            Console.WriteLine("q: Quit the Application");
        }

        public static DatabaseFile DeleteMovie(DatabaseFile db)
        {
            Console.WriteLine("=======================Delete a Movie========================");
            Console.WriteLine("What is the name of the movie you would like to delete (enter exit to cancel)?");
            Console.Write("> ");

            string userInput = Console.ReadLine();

            if (userInput.Equals("exit"))
                return db;

            Movie movie = db.FindMovieFromTitle(userInput);
            
            if(movie == null)
            {
                Console.WriteLine($"Could not find the movie named {userInput}!");
            }
            else
            {
                db.RemoveMovie(movie);
                Console.WriteLine("Movie Deleted!");
            }

            return db;
        }

        public static void DisplayAllMovies(MovieCollection movies)
        {
            Console.WriteLine($"=======================All Movies=======================");
            foreach (Movie movie in movies)
            {
                Console.WriteLine($"Title: {movie.Title}, Elo: {movie.Elo}");
            }
        }

        static void Main(string[] args)
        {
            string fileName = args[0];
            DatabaseFile dbFile = new DatabaseFile(fileName);

            bool isRunning = true;
            while(isRunning)
            {
                Console.WriteLine("What would you like to do (press h for help)?");
                Console.Write("> ");
                string input = Console.ReadLine();

                switch(input)
                {
                    case "h":
                        DisplayHelp();
                        break;
                    case "l":
                        DisplayAllMovies(dbFile.Movies);
                        break;
                    case "d":
                        dbFile = DeleteMovie(dbFile);
                        dbFile.Update();
                        break;
                    case "i":
                        //insert a new movie
                        break;
                    case "u":
                        //update a movie
                        break;
                    case "q":
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Unrecognized input!");
                        break;
                }
            }

        }
    }
}
