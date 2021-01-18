using System;
using System.Collections.Generic;
using System.Text;

namespace My_Shelf
{
    class Genre
    {
        private string[] genres = {"p-Philosopher", "c-Cumputer Science", "r-Roman", "d-Drama"};

        public void GenreOfBook()
        {
            foreach(string i in genres)
            {
                Console.WriteLine("\t" + i);
            }
        }
    }
}
