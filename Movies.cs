using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects
{
    public class Movies
    {
        const int outLine = 90;
        public string MovieTitle { get; set; }
        private string MovieRated;
        public double MyRanking { get; set; }
        private string Genre;
        public string movieRated
        {
            get { return MovieRated; }
            set {
                if (value == "R" || value == "PG13" || value == "PG" || value == "G" || value == "NR")
                {
                    MovieRated = value;
                }
                else
                {
                    MovieRated = "NR";
                    Console.WriteLine("You did not enter a valid rating!  It will be stored as [NR]");
                }
            }
        }
        public string genre
        {
            get { return Genre; }
            set {
                if(value == "A" || value == "H" || value == "D" || value == "C")
                {
                    Genre = value;
                }
                else
                {
                    Genre = "Undefined";
                    Console.WriteLine("You did not enter a valid genre!  It will be stored as [Undefined]");
                }
            }
        }
        public Movies()
        {
            // Default
        }
        public Movies(string _movieTitle, string _movieRated, string _genre, double _myRanking)
        {
            MovieTitle = _movieTitle;
            movieRated = _movieRated;
            MyRanking = _myRanking;
            Genre = _genre;
        }
        public static void Welcome() // Call this
        {
            List<Movies> movieList = new List<Movies>();
            bool anotherEntry = true; //do-while condition
            double checkedEntry = 0.0; //checking the rating
            int badEntry; //the parse out title, rating and genre
            int movieCount = 0;
            
            openScreen(); 

            do
            {
                Movies movie = new Movies();
                Console.WriteLine(new String('*', outLine));
                Console.WriteLine("Press [A] to add a movie to the movie list: ");
                var addDelete = Console.ReadLine().ToUpper();
                Console.WriteLine(new String('*', outLine));

                switch (addDelete)
                {
                    case "A":
                        try
                        {
                            Console.WriteLine("What is the movie title: ");
                            string i = Console.ReadLine();
                            bool isBadTitle = int.TryParse(i, out badEntry) || string.IsNullOrWhiteSpace(i);
                            if (isBadTitle == true)
                            {
                                Console.WriteLine("You did not enter a title!");
                            }
                            else
                            {
                                movie.MovieTitle = i;
                            }
                            Console.WriteLine(new String('*', outLine));

                            Console.WriteLine("What is the movie rated? [R, PG13, PG, G]: ");
                            string j = Console.ReadLine().ToUpper();
                            bool isBadRating = int.TryParse(j, out badEntry) || string.IsNullOrWhiteSpace(j);
                            if (isBadRating == true)
                            {
                                Console.WriteLine("You did not enter a good rating!");
                            }
                            else
                            {
                                movie.movieRated = j;
                            }
                            Console.WriteLine(new String('*', outLine));

                            Console.WriteLine("What is the movie's genre? [H] Horror, [A] Action, [D] Drama, [C] Comedy: ");
                            string y = Console.ReadLine().ToUpper();
                            bool isBadGenre = int.TryParse(y, out badEntry) || string.IsNullOrWhiteSpace(y);
                            if (isBadGenre == true)
                            {
                                Console.WriteLine("You did not enter a good genre! It will be set to [U] Undefined");
                            }
                            else
                            {
                                movie.genre = y;
                            }
                            Console.WriteLine(new String('*', outLine));

                            Console.WriteLine("What is your personal rating of the movie on a [0.0 to 10.0] scale? ");
                            string unChecked = Console.ReadLine();
                            bool goodRating = double.TryParse(unChecked, out checkedEntry);
                            if (checkedEntry <= 10.0 && checkedEntry >= 0.0)
                            {
                                movie.MyRanking = checkedEntry;
                            }
                            else
                            {
                                movie.MyRanking = 0.0;
                                Console.WriteLine("You did not enter a valid personal rating!  The rating will be set at [0.0]");
                            }
                            Console.WriteLine(new String('*', outLine));
                            
                            movieList.Add(movie);
                            movieCount++;

                            Console.WriteLine(new String('*', outLine));
                            Console.Write("Do you want to make another addition to the list? [Y/N]: ");
                            string again = Console.ReadLine().ToLower();
                            if (again != "y")
                            {
                                anotherEntry = false;
                            }
                            else if (again == "y")
                            {
                                continue;
                            }
                        }
                        catch (SystemException ex)
                        {
                            Console.WriteLine("There was an error in the entry");
                            Console.WriteLine(ex.Message);
                        }
                        break;

                    case "D":
                        Console.WriteLine("Sorry, that function is not yet completed");
                        break;
                    default:
                        Console.WriteLine("Not a valid entry");
                        break;
                }
            } while (anotherEntry);

            Console.Write("Do you want to create a file with the movie list? [Y/N]: "); //decision to write a file with the list
            string createList = Console.ReadLine().ToUpper();
            if (createList == "Y")
            {
                WriteToFile(movieList);
            }

            endScreen();

            foreach (var p in movieList) //auto displays your list in the console
            {
                Console.WriteLine($"Movie Title: {p.MovieTitle} || Movie Rated: {p.movieRated} || Movie Genre: {p.genre} || My Ranking: {p.MyRanking}");
            }
        }
        static void WriteToFile(List<Movies> theMovieList)
        {
            Console.WriteLine("Enter the file path below [ex. C:\\Users\\jon\\Desktop\\directoryName]: ");
            string FILEPATH = Console.ReadLine();

            using (StreamWriter sw = new StreamWriter(FILEPATH))
            {
                sw.WriteLine(new String('*', 40)+"WELCOME TO THE MOVIE LIST!"+new string('*', 40));
                foreach (Movies i in theMovieList)
                {
                    sw.WriteLine(i.ToPipedDelimitedString());
                }
            }
        }
        public string ToPipedDelimitedString()
        {
            return $"Movie Title: {MovieTitle} || Movie Rated: {movieRated} || Movie Genre: {genre} || My Ranking: {MyRanking}";
        }
        static void openScreen()
        {
            Console.WriteLine(new String('*', outLine));
            Console.WriteLine("\t\t\t\t WELCOME TO THE MOVIE LIST!");
            Console.WriteLine(new String('*', outLine));
            Console.WriteLine(new String('*', outLine));
        }
        static void endScreen()
        {
            Console.WriteLine(new String('*', 90));
            Console.WriteLine(new String('*', 90));
            Console.WriteLine(new String('*', 90));
            Console.WriteLine("\t\t\t***--> MOVIE LIST BELOW <--***");
            Console.WriteLine(new String('*', 90));
        }
    }
}
