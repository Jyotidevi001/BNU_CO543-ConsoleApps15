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
            Console.ForegroundColor = ConsoleColor.Cyan;
            int choice = ConsoleHelper.SelectChoice(choices);

            switch (choice)
            {
                case 1: AddMessage();break;
                case 2: AddPhoto(); break;
                case 3: PrintPosts(); break;
                case 4: break; // quit
            }

        }

        private void PrintPosts()
        {
            throw new NotImplementedException();
        }

        private void AddPhoto()
        {
            throw new NotImplementedException();
        }

        private void AddMessage()
        {
            throw new NotImplementedException();
        }
    }
}
