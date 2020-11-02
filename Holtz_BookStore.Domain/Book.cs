using System;
using System.Collections.Generic;

namespace Holtz_BookStore.Domain
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ISBN { get; set; }
        public DateTime StartDate { get; set; }


        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public ICollection<Author> Authors { get; set; }
    }
}