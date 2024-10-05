using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialProject
{
    internal class YesNoPrompt
    {
    private char _response;

        public YesNoPrompt(string input) 
        {
            Console.WriteLine(input);
            GetResponse();
        }

        public void GetResponse()
        {
            string input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input))
            {
                _response = Char.ToUpper(input[0]);
            }
            else
            {
                Console.Write("Please enter a response: ");
                GetResponse();
            }
        }

        public void ValidateResponse()
        {
            if (_response != 'Y' && _response != 'N')
            {
                Console.WriteLine("Invalid response! Please enter a valid option:");
                GetResponse();
            }
        }

        public bool isYes()
        {
            return _response == 'Y';
        }

        public bool isNo()
        {
            return _response == 'N';
        }
    }
}
