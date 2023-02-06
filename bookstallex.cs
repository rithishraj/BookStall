
using System;
using System.Collections.Generic;

using System.Data;
using System.Linq;
using System.Linq.Expressions;

namespace BookStall
{

    class Book
    {
        //all input properties
        public string Subject { get; set; }
        public int Subject_Id { get; set; }
        public int CountOfBook { get; set; }
        public int IsbnNumber { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public Boolean InStock { get; set; }

        public void AddBook()
        {

            try
            {

            label1:

                //created list to store book data
                List<Book> booklist = new List<Book>()
{
new Book { Subject = "psycics", Subject_Id = 1, CountOfBook = 5, IsbnNumber = 101, Title = "psysics", Author = "psysicsauthor",Price=12.0, InStock = true },
new Book { Subject = "chemistry", Subject_Id = 2, CountOfBook = 5, IsbnNumber = 201, Title = "chemesitry", Author = "chemestryathor",Price=13.5, InStock = true },
new Book { Subject = "maths", Subject_Id = 3, CountOfBook = 5, IsbnNumber = 301, Title = "maths", Author = "mathsauthor",Price=50.5, InStock = true }

};
                //to add user input
                booklist.Add(new Book { Subject = Subject, Subject_Id = Subject_Id, CountOfBook = CountOfBook, IsbnNumber = IsbnNumber, Title = Title, Author = Author, Price = Price, InStock = InStock });

                Console.WriteLine(" do you want to display enter yes ");
                string coun = Console.ReadLine();
                if (coun == "yes")
                {
                    goto display1;
                }
                //for add book details to the list
                Console.WriteLine("do you want to Add book");

                string add = Console.ReadLine();
                if (add == "yes")
                {
                    Console.WriteLine("enter the subject name:");
                    Subject = Console.ReadLine();
                    Console.WriteLine("enter the subject id:");
                    Subject_Id = Convert.ToInt32(Console.ReadLine());
                label2:
                    Console.WriteLine("enter the Count of book");
                    CountOfBook = Convert.ToInt32(Console.ReadLine());
                    //if count of books in each subject is check maximum 5
                    if (CountOfBook < 6)
                    {
                        goto label2;
                    }
                    Console.WriteLine("enter the isbn number:");
                    IsbnNumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter the title");
                    Title = Console.ReadLine();
                    Console.WriteLine("enter the author name");
                    Author = Console.ReadLine();
                    Console.WriteLine("enter the price");
                    Price = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("enter the in stock");
                    InStock = Convert.ToBoolean(Console.ReadLine());
                    booklist.Add(new Book { Subject = Subject, Subject_Id = Subject_Id, CountOfBook = CountOfBook, IsbnNumber = IsbnNumber, Title = Title, Author = Author, Price = Price, InStock = InStock });
                    //display all the bookdata in the list
                    //foreach (Book book in booklist)
                    //{
                    // // Console.WriteLine($"the details of book {book.Subject}, {book.Subject_Id},{book.CountOfBook},{book.IsbnNumber},{book.Title},{book.Author},{book.Price},{book.InStock}");
                    // Console.WriteLine($"the details of book subject:{book.Subject}, subjectid:{book.Subject_Id},Count of book:{book.CountOfBook},ISBN number:{book.IsbnNumber},title of the book:{book.Title},Author of the book:{book.Author},price:{book.Price},availability:{book.InStock}");

                    //}
                    Console.WriteLine($"the details of book subject:{Subject}, subjectid:{Subject_Id},Count of book:{CountOfBook},ISBN number:{IsbnNumber},title of the book:{Title},Author of the book:{Author},price:{Price},availability:{InStock}");

                }
            display1:
                //display all the book data
                Console.WriteLine("------------display all books---------------------");
                foreach (Book book in booklist)
                {
                    // Console.WriteLine($"the details of book {book.Subject}, {book.Subject_Id},{book.CountOfBook},{book.IsbnNumber},{book.Title},{book.Author},{book.Price},{book.InStock}");
                    Console.WriteLine($"the details of book subject:{book.Subject}, subjectid:{book.Subject_Id},Count of book:{book.CountOfBook},ISBN number:{book.IsbnNumber},title of the book:{book.Title},Author of the book:{book.Author},price:{book.Price},availability:{book.InStock}");

                }

                // delete the book

                Console.WriteLine("-----------Delete the book ---------------------\n do u want to delete");
                string msg = Console.ReadLine();
                if (msg == "yes")
                {
                    Console.WriteLine("enter the index to remove");
                    int ind = Convert.ToInt32(Console.ReadLine());
                    booklist.RemoveAt(ind);
                    Console.WriteLine("this book is removed");

                }

                //search operation by title
                Console.WriteLine("do you want to search by title");

                string searcht = Console.ReadLine();
                if (searcht == "yes")
                {
                    Console.WriteLine("enter the search by title");
                    string str1 = Console.ReadLine();
                    var con = from s in booklist
                              where s.Title == str1
                              select s;
                    foreach (Book book in con)
                    {
                        Console.WriteLine($"the details of book subject:{book.Subject}, subjectid:{book.Subject_Id},Count of book:{book.CountOfBook},ISBN number:{book.IsbnNumber},title of the book:{book.Title},Author of the book:{book.Author},price:{book.Price},availability:{book.InStock}");

                    }
                }
                Console.WriteLine("do you want to search by author");

                string searcha = Console.ReadLine();
                if (searcha == "yes")
                {
                    Console.WriteLine("enter the author");
                    string str2 = Console.ReadLine();
                    var con2 = from s in booklist
                               where s.Author == str2
                               select s;
                    foreach (Book book in con2)
                    {
                        //Console.WriteLine($"the details of book {book.Subject}, {book.Subject_Id},{book.CountOfBook},{book.IsbnNumber},{book.Title},{book.Author},{book.Price},{book.InStock}");
                        Console.WriteLine($"the details of book subject:{book.Subject}, subjectid:{book.Subject_Id},Count of book:{book.CountOfBook},ISBN number:{book.IsbnNumber},title of the book:{book.Title},Author of the book:{book.Author},price:{book.Price},availability:{book.InStock}");

                    }
                    foreach (Book book in booklist)
                    {
                        //Console.WriteLine($"the details of book {book.Subject}, {book.Subject_Id},{book.CountOfBook},{book.IsbnNumber},{book.Title},{book.Author},{book.Price},{book.InStock}");
                        Console.WriteLine($"the details of book subject:{book.Subject}, subjectid:{book.Subject_Id},Count of book:{book.CountOfBook},ISBN number:{book.IsbnNumber},title of the book:{book.Title},Author of the book:{book.Author},price:{book.Price},availability:{book.InStock}");

                    }

                }

                //check avaialblity
                Console.WriteLine("do u want availability of the book");

                string sto = Console.ReadLine();
                if (sto == "yes")
                {

                    var con3 = from s in booklist
                               where s.InStock == true
                               select s;
                    foreach (Book book in con3)
                    {
                        //Console.WriteLine($"the details of book {book.Subject}, {book.Subject_Id},{book.CountOfBook},{book.IsbnNumber},{book.Title},{book.Author},{book.Price},{book.InStock}");
                        Console.WriteLine($"the details of book subject:{book.Subject}, subjectid:{book.Subject_Id},Count of book:{book.CountOfBook},ISBN number:{book.IsbnNumber},title of the book:{book.Title},Author of the book:{book.Author},price:{book.Price},availability:{book.InStock}");

                    }
                }

                Console.WriteLine("do u want the modify price");

                string pri = Console.ReadLine();
                if (pri == "yes")
                {
                    Console.WriteLine("enter the isbn nuber ");
                    int isbn = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("enter the modified price");
                    double modiprice = Convert.ToDouble(Console.ReadLine());

                    var con3 = from s in booklist
                               where s.IsbnNumber == isbn
                               select s;

                    foreach (Book book in con3)
                    {
                        book.Price = modiprice;

                        //Console.WriteLine($"the details of book {book.Subject}, {book.Subject_Id},{book.CountOfBook},{book.IsbnNumber},{book.Title},{book.Author},{book.Price},{book.InStock}");
                        Console.WriteLine($"the details of book subject:{book.Subject}, subjectid:{book.Subject_Id},Count of book:{book.CountOfBook},ISBN number:{book.IsbnNumber},title of the book:{book.Title},Author of the book:{book.Author},price:{book.Price},availability:{book.InStock}");

                    }
                }

                goto label1;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }

        }


    }
}


