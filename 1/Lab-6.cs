using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_5
{
    /// Базовый класс Book
    public class Book
    {
        /// Три целочисленных поля
        private int pages;
        private int price;
        private int rating;

        /// Конструктор по умолчанию
        public Book()
        {
            pages = 0;
            price = 0;
            rating = 0;
        }

        /// Конструктор с параметрами
        public Book(int pages, int price, int rating)
        {
            this.pages = pages;
            this.price = price;
            this.rating = rating;
        }

        /// Конструктор копирования
        public Book(Book other)
        {
            this.pages = other.pages;
            this.price = other.price;
            this.rating = other.rating;
        }

        /// Свойства
        public int Pages
        {
            get { return pages; }
            set { pages = value; }
        }

        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        public int Rating
        {
            get { return rating; }
            set { rating = value; }
        }

        /// Метод для вычисления максимального из полей
        public int MaxField()
        {
            return Math.Max(pages, Math.Max(price, rating));
        }

        /// Перегрузка метода ToString()
        public override string ToString()
        {
            return $"Pages: {pages}, Price: {price}, Rating: {rating}";
        }
    }

    /// Дочерний класс eBook
    public class eBook : Book
    {
        /// Дополнительное поле
        private bool isInteractive;

        /// Конструктор по умолчанию
        public eBook() : base()
        {
            isInteractive = false;
        }
        
        /// Конструктор с параметрами
        public eBook(int pages, int price, int rating, bool isInteractive) : base(pages, price, rating)
        {
            this.isInteractive = isInteractive;
        }

        /// Конструктор копирования
        public eBook(eBook other) : base(other)
        {
            this.isInteractive = other.isInteractive;
        }

        /// Метод для вычисления общей стоимости
        public int GetTotalPrice(int discount)
        {
            return Price - discount;
        }

        /// Метод для проверки, высокий ли рейтинг
        public bool HasHighRating(int threshold)
        {
            return Rating > threshold;
        }
        
        /// Перегрузка метода ToString()
        public override string ToString()
        {
            return base.ToString() + $", Is Interactive: {isInteractive}";
        }
    }
}
