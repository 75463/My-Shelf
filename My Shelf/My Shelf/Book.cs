using System;
using System.Collections.Generic;
using System.Text;

namespace My_Shelf
{
    class Book
    {
        private string[] books = 
        {
            "Pse", "Aferdita perseri ne fshat", "Nusja pa duvak", "Ja vdekje, ja lirii" ,
            "Si behet njeriu ai qe eshte", "Shenderrimi i te gjitha vlerave", "Keshtu fali Zarathustra", "Njerzor teper Njerzor",
            "Vdekja ne shpirt", "Muri", "Me dyer te mbyllura", "Neveria",
            "Writing for a computer science.The art of effective conmunication", "How to write your first thesis", "Databases iluminated",
            "The C++ progammiming Language", "Pratice using C#", "A tour og C++", "The design and Evolution of C++",
        }; 
        public void BooksOfAuthors(int start, int end)
        {
            for(int i = start; i < end; i++)
                Console.WriteLine("\t" + books[i]);
        }
    }
}
