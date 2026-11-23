using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_04
{
    internal class Book
    {
        private string password = "secret";
        internal int copiesInStock = 5;
        public string title;
        public Genre genre = Genre.Science;
    }
}
