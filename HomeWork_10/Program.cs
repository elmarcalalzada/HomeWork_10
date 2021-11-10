using System;
using System.Collections.Generic;

namespace HomeWork_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            library.Books.Add(
                new Book
                {
                    AuthorName = "Fyodor  Dostoyevski",
                    Name = "Cinayet və ceza",
                    PageCount = 448
                });
            library.Books.Add(
                new Book
                {
                    AuthorName = "Ceyn Ostin",
                    Name = "Qurur və qerez",
                    PageCount = 332
                });
            library.Books.Add(
                new Book
                {
                    AuthorName = "Alber Kamyu",
                    Name = "Yad",
                    PageCount = 298
                });
            library.Books.Add(
                new Book
                {
                    AuthorName = "Lev Tolstoy",
                    Name = "Anna Karenina",
                    PageCount = 508
                });
            
            Console.WriteLine("Kitabxanadaki kitablar:");
            foreach (var item in library.Books)
            {
                Console.WriteLine(item.Name);
            }


            Console.WriteLine("Baxmaq istediyiniz kitab: ");
            string bookName = Console.ReadLine();
            List<Book> nameList = library.FindAllBooksByName(bookName);
            foreach (var item in nameList)
            {
                library.ShowInfo(item);
            }

            Console.WriteLine("Silmek istediyiniz kitab: ");
            string removeName = Console.ReadLine();
            library.RemoveAllBookByName(removeName);
            Console.WriteLine("Kitabxanadaki kitablar:");
            foreach (var item in library.Books)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine("Axtardiginiz kitabin melumatlarini daxil edin: Name/Author Name/Page Count");
            string searchBook = Console.ReadLine();
            List<Book> searchList = library.SearchBooks(searchBook);
            foreach (var item in searchList)
            {
                library.ShowInfo(item);
            }

            Console.WriteLine("Kitabin minimum ve maximum sehife saylarini daxil edin: ");
            Console.WriteLine("Min: ");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine("Max: ");
            int max = int.Parse(Console.ReadLine());
            List<Book> pageCountList = library.FindAllBooksByPageCountRange(min, max);
            foreach (var item in pageCountList)
            {
                library.ShowInfo(item);
            }
  
            Console.WriteLine("Silmek istediyiniz kitabin No deyeri: ");
            int no = int.Parse(Console.ReadLine());
            library.RemoveByCode(no);
            Console.Clear();
            Console.WriteLine("Kitabxanadaki kitablar:");
            foreach (var item in library.Books)
            {
                library.ShowInfo(item);
            }

        }
    }
}
