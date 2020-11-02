using Holtz_BookStore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Holtz_BookStore.API.Repositories.Contracts
{
    public interface IAuthorRepository : IDisposable //This interface IDisposable will oblige close connection with DataBase
    {
        List<Author> Get();
        Author Get(int id);
        List<Author> GetByName(string name);
        bool Create(Author author);
        void Update(Author author);
        bool Delete(int id);
    }
}