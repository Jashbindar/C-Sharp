using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialProject
{
    internal class Option
    {
        private char user_choice {  get; set; }
        public Option(char a_user_choice)
        {
            user_choice = a_user_choice;
        }

        public Option() { }
        public char User_choice() { return user_choice; }
    }
}
