using homeworkdelegate2.Models;
using System;
using UtilsClassLibrary.Enums;

namespace homeworkdelegate2
{
    class Program
    {
        static void Main(string[] args)
        {
            byte role;
            bool isNum;
            do
            {
                Console.WriteLine("Role:");
                string roleStr = Console.ReadLine();
                isNum = byte.TryParse(roleStr, out role);
            } 
            while (!isNum || !Enum.IsDefined(typeof(Role), role));
            Library library = new Library();
            Console.WriteLine("Menu");
            Console.WriteLine("1. Add book");
            Console.WriteLine("2. Get book by id");
            Console.WriteLine("3. Get all books");
            Console.WriteLine("4. Delete book by id");
            Console.WriteLine("5. Edit book name");
            Console.WriteLine("6. Filter by page count");
            Console.WriteLine("0. Quit");
        }
    }
}
