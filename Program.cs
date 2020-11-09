using System;

namespace std
{
    class Program
    {
        static void Main(string[] args)
        {

            Student s1 = new Student();
            s1.Name = "Maliha";
            s1.Id = "11223344";
            s1.Department = "CSE";
            s1.Cgpa = 3.33f;
            s1.showInfo();


            


            Account a1 = new Account();
            a1.Name = "Maliha";
            a1.Id = "12344323";
            a1.Balance = "90,000";
            a1.ShowInfo();
            Console.WriteLine();
            a1.Deposit(6);
            Console.WriteLine();
            a1.Withdraw(1);



           
            Book b1 = new Book ();
            b1.Name = "history";
            b1.Author = "hsgdiibcbw";
            b1.Id = "4241";
            b1.Copy = 1;
            b1.showInfo();


           


            Library l1 = new Library();
            l1.Name = "Ekushey Boi Ghor";
            l1.Address = "dhaka ";
            l1.TotalBooks = "4241";
            l1.AddNewBooks(b1, b2);
            l1.ShowAllBooks();
        }
    }
}