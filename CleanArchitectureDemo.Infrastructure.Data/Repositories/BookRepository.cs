using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Domain.Models;
using CleanArchitecture.Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Infrastructure.Data.Repositories
{
    public class BookRepository : IBookRepository
    {
        public LibraryDbContext _context;
        public BookRepository(LibraryDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Book> GetBooks()
        {
            return _context.Books;
        }
    }
}