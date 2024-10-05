using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialProject
{
    internal class User_Information
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public int Id { get; set; }

        public User_Information(string name, string email, string description, int id)
        {
            Name = name;
            Description = description;
            Email = email;
            Id = id;
        }

        public User_Information() { }
    }
}
