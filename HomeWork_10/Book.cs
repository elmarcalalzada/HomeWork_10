using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_10
{
    class Book
    {
        public Book()
        {
            noTemp++;
            No = noTemp;
        }

        private static int noTemp = 0;
        private int _no;

        public int No
        {
            get { return _no; }
            private set { _no = value; }
        }

        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }

    }
}
