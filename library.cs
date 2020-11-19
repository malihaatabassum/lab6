using System;
using System.Collections.Generic;
using System.Text;

namespace std
{
    class Library
    {
        private string LName;

        public string lName
        {
            get { return lName; }
            set { lName = value; }
        }
        private string lAddress;

        public string LAddress
        {
            get { return lAddress; }
            set { lAddress = value; }
        }
        private int totalBooks;

        public int TotalBooks
        {
            get { return totalBooks; }
            set { totalBooks = value; }
        }
        Book[] listOfBooks;
        public Library() { }
        public Library(string lName, string lAddress, int totalBooks, int sizeOfArray)
        {
            this.lName = lName;
            this.lAddress = lAddress;
            this.totalBooks = totalBooks;
            listOfBooks = new Book[sizeOfArray];
        }
        public void AddNewBooks(params Book[] book)
        {
            foreach (var b in book)
            {
                for (int i = 0; i < listOfBooks.Length; i++)
                {
                    if (listOfBooks[i] == null)
                    {
                        listOfBooks[i] = b;
                        break;
                    }
                }
            }
            totalBooks++;
        }

        public void DeleteBook(params Book[] book)
        {
            foreach (var b in book)
            {
                for (int i = 0; i < listOfBooks.Length; i++)
                {
                    if (listOfBooks[i] == b)
                    {
                        listOfBooks[i] = null;
                        break;
                    }
                }
            }
            totalBooks--;
        }
        public void AddNewBookCopy(Book book, int copy)
        {
            if (copy > 0)
            {
                for (int i = 0; i < listOfBooks.Length; i++)
                {
                    if (listOfBooks[i] == null)
                    {
                        listOfBooks[i] = book;
                        break;
                    }
                }
                totalBooks = totalBooks + copy;

            }
        }
        public void ShowAllBooks()
        {
            foreach (Book b in listOfBooks)
            {
                if (b != null)
                {
                    b.ShowInfo();
                }
            }
        }


    }
}