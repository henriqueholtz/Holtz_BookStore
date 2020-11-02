using System;
using System.Collections.Generic;

namespace Holtz_BookStore.Domain
{
    public class Author
    {
        public Author()
        {
            Books = new List<Book>();
        }

        public int Id { get; set; }
        public string Name { get; set; }


        public ICollection<Book> Books { get; set; }
    }
}