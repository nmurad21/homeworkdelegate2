using homeworkdelegate2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace homeworkdelegate2.Models
{
    class Book:IEntity
    {
        private static int _id;
        public int Id { get; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        public bool IsDeleted { get; set; }
        public Book(string name, string authorname, int pagecount)
        {
            _id++;
            Id = _id;
            Name = name;
            AuthorName = authorname;
            PageCount = pagecount;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Id:{Id}--- Name:{Name}--- AuthorName:{AuthorName}--- PageCount:{PageCount}");
        }
    }
}
