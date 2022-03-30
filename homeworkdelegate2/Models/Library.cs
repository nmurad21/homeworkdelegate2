using homeworkdelegate2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using UtilsClassLibrary.Exceptions;

namespace homeworkdelegate2.Models
{
    class Library : IEntity
    {
        private static int _id;
        public int Id { get; }
        public int BookLimit { get; set; }
        private List<Book> _books;
        public Library()
        {
            _books = new List<Book>();
        }
        public void AddBook(Book book)
        {
            if (_books.Exists(b => b.Name == book.Name && !b.IsDeleted))
            {
                throw new AlreadyExistsException("Bu adda book var");
            }
            if (_books.Count < BookLimit)
            {
                _books.Add(book);
                return;
            }
            throw new CapacityLimitException("Limit asildi");
        }
        public Book GetBookById(int? id)
        {
            if (id == null)
            {
                throw new NullReferenceException("Null ola bilmez");
            }
            Book book = _books.Find(b => !b.IsDeleted && b.Id == id);
            if (book==null)
            {
                throw new NullReferenceException("Null ola bilmez");
            }
            return book;

        }
        public List<Book> GetAllBooks()
        {
            List<Book> copyBooks = new List<Book>();
            copyBooks.AddRange(_books.FindAll(b => !b.IsDeleted));
            return copyBooks;

        }
        public void DeleteBookById(int? id)
        {
            if (id == null)
            {
                throw new NullReferenceException("Null ola bilmez");
            }
            Book book = _books.Find(b => !b.IsDeleted && b.Id == id);
            if (book==null)
            {
                throw new NotFoundException("bele bir kitab yoxdur");
            }
            book.IsDeleted = true;
        }
        public Book EditBookName(int? id, string name)
        {
            if (id == null)
            {
                throw new NullReferenceException("Null ola bilmez");
            }
            Book book = _books.Find(b => !b.IsDeleted && b.Id == id);
            if (book==null)
            {
                throw new NotFoundException("Bele bir kitab yoxdur");
            }
            book.Name = name;
            return book;
        }
        public Book FilterByPageCount(int minPageCount, int maxPageCount)
        {
            return _books.Find(b => b.PageCount > minPageCount && b.PageCount < maxPageCount && !b.IsDeleted);
        }
    }
}
