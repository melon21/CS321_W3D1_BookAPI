using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CS321_W3D1_BookAPI.Data;
using CS321_W3D1_BookAPI.Models;

namespace CS321_W3D1_BookAPI.Services
{
    public class BookService : IBookService
    {
        private readonly BookContext _bookContext;
        public BookService(BookContext bookContext)
        {
            _bookContext = bookContext;
        }


        //public BookContext = new BookContext();
        public void Delete(Book deletedBook)
        {
            throw new NotImplementedException();
        }

        public Book Get(int bookId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> GetAll()
        {
            return _bookContext.Books.ToList();
        }

        public Book Post(Book newBook)
        {
            throw new NotImplementedException();
        }

        public Book Update(Book UpdatedBook)
        {
            throw new NotImplementedException();
        }
    }
}
