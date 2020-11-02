using Holtz_BookStore.API.Data;
using Holtz_BookStore.API.Repositories.Contracts;
using Holtz_BookStore.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Holtz_BookStore.API.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly Datacontext _context = new Datacontext();
        public bool Create(Author author)
        {
            try
            {
                _context.Authors.Add(author);
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
            var author = _context.Authors.Find(id);
            try
            {
                _context.Authors.Remove(author);
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
            _context.Dispose(); //To antecipe dispose of EntityFramework
        }

        public List<Author> Get()
        {
            return _context.Authors.ToList();
        }

        public Author Get(int id)
        {
            return _context.Authors.Find(id);
        }

        public List<Author> GetByName(string name)
        {
            return _context.Authors.Where(x => x.Name.Contains(name)).ToList();
        }

        public void Update(Author author)
        {
            try
            {
                _context.Entry<Author>(author).State = EntityState.Modified;
                _context.SaveChanges();

            }
            catch
            {

            }
        }
    }
}