using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialProject
{
    internal class User_List
    {
        private List<User_Information> _information;
        public User_List()
        {
            _information = new List<User_Information>();
        }
        public void Add_user(User_Information user) { _information.Add(user); }
        public void Remove_user(User_Information user) { _information.Remove(user); }
        public void Display_user(User_Information user)
        {
            Console.WriteLine();
            Console.WriteLine(user.Name);
            Console.WriteLine(user.Id);
            Console.WriteLine(user.Email);
            Console.WriteLine(user.Description);
            Console.WriteLine();
        }
        public void Display_all_users()
        {
            Console.WriteLine("All users:");
            foreach (User_Information user in _information)
            {
                Console.WriteLine($"ID: {user.Id}, Name: {user.Name}, Email {user.Email}, Description {user.Description}");
            }
        }
        public User_Information findUser(int id_num)
        {
            for (int i = 0; i < _information.Count; i++)
            {
                if (_information[i].Id == id_num)
                {
                    return _information[i];
                }
            }
            return null;
        }
    }
}
