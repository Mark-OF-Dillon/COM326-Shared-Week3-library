using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Library
{
    public class Book
    {
        //Private Fields//
        private string title;
        private string author;
        private string isbn;

        //Public Properties//
        public string Title 
        {
            get { return title; }
            private set
            {
                // Ensure name does not contain any numbers
                if (!value.Any(char.IsDigit) && value != "")
                {
                    title = value;
                }
                else
                {
                    Console.WriteLine("Error: Title cannot be blank or contain numbers.");
                }
            }
        }
        public string Author
        {
            get { return author; }
            private set
            {
                // Ensure name does not contain any numbers
                if (!value.Any(char.IsDigit) && value != "")
                {
                    author = value;
                }
                else
                {
                    Console.WriteLine("Error: Author cannot be blank or contain numbers.");
                }
            }
        }
        public string ISBN
        {
            get { return isbn; }
            private set
            {
                // Ensure name does not contain any numbers
                if (!value.Any(char.IsDigit) && value != "")
                {
                    isbn = value;
                }
                else
                {
                    Console.WriteLine("Error: ISBN cannot be blank or contain numbers.");
                }
            }
        }

        //Constructor//
        public Book(string bookTitle, string bookAuthor, string bookISBN)
        {
            this.Title = bookTitle;
            this.Author = bookAuthor;
            this.ISBN = bookISBN;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Book title: {Title}");
            Console.WriteLine($"Book Author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
            Console.WriteLine();
        }
    }
} 
    
