using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualBookingSystem
{
    public class Book
    {
        public string Titel { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }

        public Book(string titel, string author, string isbn)
        {
            Titel = titel;
            Author = author;
            ISBN = isbn;
        }

        public virtual void SkrivUtInfo()
        {
            Console.WriteLine("Bokdetaljer:");
            Console.WriteLine($"Titel: {Titel}");
            Console.WriteLine($"Författare: {Author}");
            Console.WriteLine($"ISBN: {ISBN}");
        }
    }
}
