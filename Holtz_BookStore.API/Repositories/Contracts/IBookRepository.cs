using Holtz_BookStore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Holtz_BookStore.API.Repositories.Contracts
{
    public interface IBookRepository : IDisposable //This interface IDisposable will oblige close connection with DataBase
    {
        List<Book> FindAll();
        Book FindById(int id);
        List<Book> FindByName(string name);
        List<Category> FindAllCategories();
        bool Create(Book book);
        bool Update(Book book);
        bool Delete(int id);
    }
}