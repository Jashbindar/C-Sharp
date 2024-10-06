using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialProject
{
    internal class Admin : User_Information
    {
        private int Admin_Id;
        private string Admin_name;

        public Admin(int admin_id, string admin_name) : base()
        {
            Admin_Id = admin_id;
            Admin_name = admin_name;
        }

        public Admin() { }

        public int AdminId
        {
            get { return Admin_Id; }
            set { Admin_Id = value; }
        }

        public string AdminName
        {
            get { return Admin_name; }
            set { Admin_name = value; }
        }
    }
}
