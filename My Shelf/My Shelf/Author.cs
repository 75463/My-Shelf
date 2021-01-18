using System;
using System.Collections.Generic;
using System.Text;

namespace My_Shelf
{
    class Author
    {
        private string[] authors = {"s-Sterio Spasse", "f-Frederik Nice", "z-Zhan Pol Sartri", "j-Justin Zobel", "b-Bjarne Stroustruo", "--", "--", "--", "--", "--"};

        public void PAuthors()
        {
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("\t" + authors[i]);
            }
        }
        public void CAuthors()
        {
            for (int i = 3; i < 5; i++)
            {
                Console.WriteLine("\t" + authors[i]);
            }
        }
        public void RAuthors()
        {
            for (int i = 5; i < 7; i++)
            {
                Console.WriteLine("\t" + authors[i]);
            }
        }
        public void DAuthors()
        {
            for (int i = 7; i < 10; i++)
            {
                Console.WriteLine("\t" + authors[i]);
            }
        }
    }

}
