using Holtz_BookStore.API.Data;
using Holtz_BookStore.API.Repositories.Contracts;
using Holtz_BookStore.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace Holtz_BookStore.API.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly Datacontext _context = new Datacontext();

        public bool Create(Book book)
        {
            try
            {
                _context.Books.Add(book);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                Book book =_context.Books.Find(id);
                _context.Books.Remove(book);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public List<Book> FindAll()
        {
            return _context.Books.ToList();
        }

        public List<Category> FindAllCategories()
        {
            return _context.Categories.ToList();
        }

        public Book FindById(int id)
        {
            return _context.Books.Find(id);
        }

        public List<Book> FindByName(string name)
        {
            return _context.Books.Where(x => x.Name.Contains(name)).ToList();
        }

        public bool Update(Book book)
        {
            try
            {
                _context.Books.AddOrUpdate(book);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}