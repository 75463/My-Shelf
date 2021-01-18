using System;

namespace My_Shelf
{
    class Shelf
    {
        static void Main(string[] args)
        {
            Genre g = new Genre();
            Author a = new Author();
            Book b = new Book();

            Console.WriteLine("Choose a genre from the following list:");
            g.GenreOfBook();

            string choice = Console.ReadLine();
            string choice2 = choice.ToUpper();

            if(choice2 == "P")
            {
                Console.WriteLine("Choose author: ");
                a.PAuthors();

                string choice3 = Console.ReadLine();
                string choice4 = choice3.ToUpper();
                if (choice4 == "S")
                    b.BooksOfAuthors(0, 4);
                else if (choice4 == "F")
                    b.BooksOfAuthors(4, 8);
                else if (choice4 == "Z")
                    b.BooksOfAuthors(8, 12);
                else
                    Console.WriteLine("Author not found");

            }
            else if(choice2 == "C")
            {
                Console.WriteLine("Choose author: ");
                a.CAuthors();
                
                string choice5 = Console.ReadLine();
                string choice6 = choice5.ToUpper();
                if (choice6 == "J")
                    b.BooksOfAuthors(12, 15);
                else if (choice6 == "B")
                    b.BooksOfAuthors(15, 19);
                else
                    Console.WriteLine("Author not found");

            }
            else if(choice2 == "R")
            {
                Console.WriteLine("Choose author: ");
                a.RAuthors();
            }
            else if(choice2 == "D")
            {
                Console.WriteLine("Choose author: ");
                a.DAuthors();
            }
            else
            {
                Console.WriteLine("Genre not found");
            }
            Console.ReadKey();
        }
    }
}
