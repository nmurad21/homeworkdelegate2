using homeworkdelegate2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using UtilsClassLibrary.Enums;

namespace homeworkdelegate2.Models
{
    class User : IEntity
    {
        private static int _id;
        public int Id { get; }
        public string Username { get; set; }
        public string Email { get; set; }
        public Role Role { get; set; }
        public void ShowInfo()
        {
            Console.WriteLine($"Id:{Id}-- Username:{Username}-- Email:{Email}-- Role:{Role} ");
        }
        public User(string username, string email, Role role)
        {
            _id++;
            Id = _id;
            Username = username;
            Email = email;
            Role = role;

        }
    }
}
