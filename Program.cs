namespace TutorialProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User_List list = new User_List();

            string name, email, description, input;
            int number, id_num;
            char user_choice;

            while (true)
            {
                Console.WriteLine("\n1. Add user");
                Console.WriteLine("2. Remove user");
                Console.WriteLine("3. Display user");
                Console.WriteLine("\nEnter your choice:");
                user_choice = Convert.ToChar(Console.ReadLine());
                Option option = new Option(user_choice);

                switch (option.User_choice())
                {
                    case '1':
                        Console.WriteLine("\nEnter your name:");
                        name = Console.ReadLine();
                        Console.WriteLine("\nEnter your email:");
                        email = Console.ReadLine();
                        Console.WriteLine("\nEnter your description:");
                        description = Console.ReadLine();
                        Console.WriteLine("\nEnter your number:");
                        while (!int.TryParse(Console.ReadLine(), out number))
                        {
                            Console.Write("Invalid input! Please enter a valid phone number: ");
                        }

                        User_Information info = new User_Information(name, email, description, number);
                        list.Add_user(info);
                        list.Display_user(info);
                        break;

                    case '2':
                        Console.WriteLine("\nEnter the id number to be removed:");
                        id_num = Convert.ToInt32(Console.ReadLine());

                        User_Information id_to_remove = list.findUser(id_num);

                        if (id_to_remove != null) 
                        {
                            list.Remove_user(id_to_remove);
                            Console.WriteLine("{0} has been removed", id_to_remove.Name);
                        }
                        break;

                    case '3':
                        YesNoPrompt yesNoPrompt = new YesNoPrompt("Would you like to display a single user? (Y/N):");
                        if (yesNoPrompt.isYes())
                        {
                            Console.WriteLine();
                            Console.WriteLine("Enter the id of the user:");

                            id_num = Convert.ToInt32(Console.ReadLine());
                            User_Information id_to_find = list.get_user(id_num);

                            if (id_to_find != null)
                            {
                                list.Display_user(id_to_find);
                            }
                        }
                        else
                        {
                            list.Display_all_users();
                        }
                        break;
                }
            }
        }
    }
}