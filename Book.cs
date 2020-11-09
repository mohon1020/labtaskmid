using System;
using System.Collections.Generic;
using System.Text;

namespace DClass
{
    class Book
    {
        string bookName;
        string bookAuthor;
        string bookId;
        string bookType;
        int bookcopy;

        Book() { }
        Book(string bName, string bAuthor, string bId, string bType,int x)
        {
            this.bookName = bName;
            this.bookAuthor = bAuthor;
            this.bookId = bId;
            this.bookType = bType;
            void AddBookCopy(int x)
            {
                ++x;
                Console.WriteLine(x);
            }
        }

    }
}
