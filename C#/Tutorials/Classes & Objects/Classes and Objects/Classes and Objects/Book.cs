using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_and_Objects
{
    class Book
    {
        public string sTitle;
        public string sAuthor;
        public int iPages;

        public Book(string aTittle, string aAuthor, int aPages)
        {
            sTitle = aTittle;
            sAuthor = aAuthor;
            iPages = aPages;
        }

    }
}
