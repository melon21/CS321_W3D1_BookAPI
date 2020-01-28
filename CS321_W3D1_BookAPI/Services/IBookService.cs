using CS321_W3D1_BookAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS321_W3D1_BookAPI.Services
{
    public interface IBookService
    {
        IEnumerable<Book> GetAll();

        Book Get(int bookId);

        Book Post(Book newBook);

        Book Update(Book UpdatedBook);

        void Delete(Book deletedBook);
    }
}
