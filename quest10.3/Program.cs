using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace quest10._3
{
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
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(TitleText);
        }
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
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(ContentText);
        }
    }
    class Book
    {
        Title title;
        Author author;
        Content content;

        void InitialiseBook()
        {
            this.title = new Title();
            this.author = new Author();
            this.content = new Content();
        }
        public Book(Title title, Author author, Content content)
        {
            this.title = title;
            this.author = author;
            this.content = content;
        }

        public void Show()
        {
            this.title.Show();
            this.author.Show();
            this.content.Show();
        }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.Title = "Заголовок";
            book.Author = "Автор";
            book.Content = "Текст";


            Console.ReadKey();
        }
    }
}
