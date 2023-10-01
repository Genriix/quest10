using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace quest10._3
{
    class Book
    {
        private string book;

    }
    class Author
    {
        private string author;
        public string AuthorName
        {
            set { author = value; }
            get { return author; }
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(AuthorName);
        }
    }
    class Title
    {
        private string title;
        public string TitleText
        {
            set { title = value; }
            get { return title; }
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(TitleText);
        }
    }
    class Content
    {
        private string content;
        public string ContentText
        {
            set { content = value; }
            get { return content; }
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(ContentText);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            Author book = new Author();
            Title book = new Title();
            book.BookName = "Террор";
            book.Show();



            Console.ReadKey();
        }
    }
}
