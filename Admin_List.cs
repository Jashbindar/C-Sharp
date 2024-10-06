using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialProject
{
    internal class Admin_List : User_List
    {
        public List<Admin> admins { get; set; }

        public Admin_List()
        {
            admins = new List<Admin>();
        }

        public void Add_admin(Admin admin) { admins.Add(admin); }
        public void Remove_admin(Admin admin) { admins.Remove(admin); }
        public void Display_admin(Admin admin) 
        {
            Console.WriteLine();
            Console.WriteLine(admin.Id);
            Console.WriteLine(admin.Name);
            Console.WriteLine();
        }

        public void Display_all_admins() 
        {
            Console.WriteLine("All admins:");
            foreach (Admin admin in admins)
            {
                Console.WriteLine($"ID: {admin.Id}, Name: {admin.Name}");
            }
        }

        public Admin findAdmin(int id)
        {
            for (int i = 0; i < admins.Count; i++)
            {
                if (admins[i].Id == id)
                {
                    return admins[i];
                }
            }
            return null;
        }
    }
}
