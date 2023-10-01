using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questTest
{
    class Title
    {
        string content;
        public string Content
        {
            private get
            {
                if (content != null)
                    return content;
                else
                    return "Заголовок отсутствует.";
            }
            set
            {
                content = value;
            }
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(content);
        }
    }
    class Author
    {
        string content;
        public string Content
        {
            private get
            {
                if (content == null ^ content == "")
                    return "Автор отсутствует...";
                else
                    return content;
            }
            set
            {
                content = value;
            }
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Content);
        }
    }
    class Content
    {
        string story;
        public string Story // Свойство поля
        {
            get
            {
                if (story == null ^ story == "")
                    return "Текст книги отсутствует";
                else
                    return story;
            }
            set
            {
                story = value;
            }
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Story);
        }
    }
    class Book
    {
        Title title = null;
        Content story = null;
        Author author = null;
        void InitializeBook()
        {
            this.title = new Title();
            this.story = new Content();
            this.author = new Author();
        }
        // конструктор класса Document?
        public Book(string title)
        {
            InitializeBook(); // Создали объекты классов
            this.title.Content = title; // Записали заголовк в поле tile (объект класса Title)           
        }
        public void Show()
        {
            this.title.Show(); // Обращаемся к методу класса title
            this.story.Show();
            this.author.Show();
        }
        // Свойство поля story
        public string Story
        {
            set
            {
                this.story.Story = value;
            }
        }
        // Свойство поля author
        public string Author
        {
            set
            {
                this.author.Content = value;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Золотая рыбка"); // Создание объекта класса Book
            book.Story = "Жили были старик со старухой у самого синего моря...";
            book.Author = "Пушкин А.С.";
            book.Show();
            Console.ReadKey();
        }
    }
}
