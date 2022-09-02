using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Libraryv2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Making stack
            Stack<Book> bookinstack = new Stack<Book>();

            //valueable
            string pushbook = "";

            // Making instance of manager
            Manager manager = new Manager();

            //Checks for available books
            Console.WriteLine("Available books \n");
            foreach (Book i in manager.Books)
            {
                Console.WriteLine(i.Title);
            }

            // asks user what book they would like to check out
            Console.WriteLine("\n What book would you like to check out?");
            pushbook = Console.ReadLine();

            //Chekc out book
            //Linq solution
            // Book x = manager.books.Find(x => x.Title == pushbook);

            foreach (Book i in manager.Books)
            {
                if (pushbook == i.Title)
                {
                    bookinstack.Push(i);
                    manager.Books.Remove(i);

                }

            }

            //shows books in stack

            foreach (Book i in bookinstack)
            {
                Console.WriteLine(i);
            }

            // pop books in stack, if there is more than 0
            try
            {
                while (bookinstack.Count() > 0)
                {
                    Console.WriteLine(bookinstack.Pop());
                }
            }
            catch (Exception)
            {

                throw;
            }

            
        }
    }
}
