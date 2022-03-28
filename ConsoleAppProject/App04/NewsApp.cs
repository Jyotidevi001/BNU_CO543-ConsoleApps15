using System;
using System.Collections.Generic;
using System.Text;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App04
{
    
    public class NewsApp
    {
        public NewsList NewsList { get; set; } = new NewsList();

        string[] choices =
        {
            " Add a Message Post",
            "Add a Photo Post",
            "Display",
            "Quit"
        };
        public void Run()
        {
            Console.WriteLine(" App04 my NewsApp");
            bool quit = false;
            while (quit == false)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                int choice = ConsoleHelper.SelectChoice(choices);

                switch (choice)
                {
                    case 1: AddMessage(); break;
                    case 2: AddPhoto(); break;
                    case 3: PrintPosts(); break;
                    case 4: quit = true; break ; // quit
                }
            }
           
        }

        private void PrintPosts()
        {
            NewsList.Display();
             
        }

        private void AddPhoto()
        {
            throw new NotImplementedException();
        }

        private void AddMessage()
        {
            string name = EnterAuthor();

            Console.Write("please enter your message >");
            string message = Console.ReadLine();

            MessagePost post = new MessagePost(name, message);
            NewsList.AddPost(post);


        }

        private static string EnterAuthor()
        {
            Console.Write(" please enter your name >");
            string name = Console.ReadLine();
            return name;
        }
    }
}
