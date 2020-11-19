using System;
using System.Collections.Generic;
using System.Text;

namespace std
{
    class Book
    {
        private string bName;

        public string BName
        {
            get { return bName; }
            set { bName = value; }
        }
        private string bAuthor;

        public string BAuthor
        {
            get { return bAuthor; }
            set { bAuthor = value; }
        }
        private string bId;

        public string BId
        {
            get { return bId; }
            set { bId = value; }
        }
        private string bType;

        public string BType
        {
            get { return bType; }
            set { bType = value; }
        }
        private int bCopy;

        public int BCopy
        {
            get { return bCopy; }
            set { bCopy = value; }
        }

        public Book() { }
        public Book(string bName, string bAuthor, string bId, int bCopy)
        {
            this.bName = bName;
            this.bAuthor = bAuthor;
            this.bId = bId;
            this.bCopy = bCopy;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Book Name : " +  bName);
            Console.WriteLine("Author : " + bAuthor);
            Console.WriteLine(" ID : " + bId);
            Console.WriteLine(" Type : " + bType);
            Console.WriteLine("Available book : " + bCopy);
        }
        public void AddBCopy(int x)
        {
            if (x >= 0)
            {
                bCopy = bCopy + x;
                Console.WriteLine("Available book : " + bCopy);
            }
        }



    }
}