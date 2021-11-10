using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_10
{
    class Library
    {
        public List<Book> Books;
        public Library()
        {
            Books = new List<Book>();
        }

        public List<Book> FindAllBooksByName(string bookName)
        {
            List<Book> listByName = new List<Book>();
            bool check = false;
            if (!string.IsNullOrEmpty(bookName))
            {
                foreach (var item in Books)
                {
                    if (item.Name == bookName)
                    {
                        listByName.Add(item);
                        check = true;
                    }
                }
            }
            if (!check)
            {
                Console.WriteLine("Bu Adda Kitab Yoxdur!");
            }
            return listByName;
        }

        public void RemoveAllBookByName(string bookName)
        {
            if (!string.IsNullOrEmpty(bookName))
            {
                for (int i = 0; i < Books.Count; i++)
                {
                    if (Books[i].Name == bookName)
                    {
                        Books.Remove(Books[i]);
                    }
                }
            }
            else
            {
                Console.WriteLine("Silmek Istediyiniz kitab yoxdur!");
            }
        }

        public List<Book> SearchBooks(string value)
        {
            List<Book> books = new List<Book>();
            if (!string.IsNullOrEmpty(value))
            {
                foreach (var item in Books)
                {
                    if (item.PageCount.ToString() == value || item.Name == value || item.AuthorName == value)
                    {
                        books.Add(item);
                    }
                }
            }
            return books;
        }

        public List<Book> FindAllBooksByPageCountRange(int minPage, int maxPage)
        {
            List<Book> pageAverage = new List<Book>();
            foreach (var item in Books)
            {
                if (item.PageCount > minPage && item.PageCount < maxPage)
                {
                    pageAverage.Add(item);
                }
            }
            return pageAverage;
        }

        public void RemoveByCode(int no)
        {
            bool noCheck = false;
            for (int i = 0; i < Books.Count; i++)
            {
                if (Books[i].No == no)
                {
                    Books.Remove(Books[i]);
                    noCheck = true;
                }
            }
            if (!noCheck)
            {
                Console.WriteLine("Daxil olunan nomrede kitab yoxdur!");
            }
        }

        public void ShowInfo(Book book)
        {
            Console.WriteLine($"Author name: {book.AuthorName}\nName: {book.Name}\nBook no: {book.No}\nPage count: {book.PageCount}");
        }
    }
}
