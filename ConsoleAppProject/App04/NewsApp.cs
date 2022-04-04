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
                    case 2: AddPhoto();   break;
                    case 3: PrintPosts(); break;
                    case 4: DisplayAll(); break;
                    case 5: RemovePost(); break;
                    case 6: AddCommentsToPost(); break;
                    case 7: LikePost(); break;
                    case 8: UnlikePost(); break;
                    case 9: quit = true; break ; // quit
                }
            }
           
        }

        private void UnlikePost()
        {
            int id = (int)ConsoleHelper.InputNumber("please enter the Post ID:");
            NewsList.UnlikePost(id);

        }

        private void LikePost()
        {
            int id = (int)ConsoleHelper.InputNumber("please enter the Post ID:");
            NewsList.LikePost(id);
        }

        private void AddCommentsToPost()
        {
            int id = (int)ConsoleHelper.InputNumber("please enter the Post ID:");
            Console.WriteLine("please enter a comment:");
            string comments = Console.ReadLine();

            NewsList.AddCommentToPost(id, comments);
        }

        private void RemovePost()
        {
            ConsoleHelper.OutputTitle($"Removing a post");

            int id = (int)ConsoleHelper.InputNumber("please enter the post ID:");
            NewsList.RemovePost(id);
        }

        private void DisplayAll()
        {
            NewsList.Display();
        }

        private void PrintPosts()
        {
            NewsList.Display();
             
        }

        private void AddPhoto()
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();

            Console.WriteLine("\nEnter the photi filename:");
            string filename = Console.ReadLine();

            Console.WriteLine("\nEnter the photo caption:");
            string caption = Console.ReadLine();
            PhotoPost photopost = new PhotoPost(name, filename, caption);
            NewsList.AddPhotoPost(photopost);
        }

        private void AddMessage()
        {
            string name = EnterAuthor();

            Console.Write("please enter your message >");
            string message = Console.ReadLine();

            MessagePost post = new MessagePost(name, message);
            NewsList.AddMessagePost(post);


        }

        private static string EnterAuthor()
        {
            Console.Write(" please enter your name >");
            string name = Console.ReadLine();
            return name;
        }
    }
}
