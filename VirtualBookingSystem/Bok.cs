using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualBookingSystem
{
    public class Bok
    {
        string Title { get; set; }
        string Author { get; set; }
        string ISBN { get; set; }

        public Bok(string title,string author,string isbn)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
        }

        public virtual void printInfo()
        {
            Console.WriteLine($"Title:{Title}\nAuthor:{Author}\nISBN{ISBN}");
        }
    }
}
