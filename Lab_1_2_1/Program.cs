using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_2_1_lab
{
    //abstract class Cl
    //{
    //    public string str;
        
    //}
    class Program
    {
        static void Main(string[] args)
        {
            LibraryUser User1 = new LibraryUser();
            LibraryUser User2 = new LibraryUser("John", "Smith", "911", 0996852498 , 5);




            // 8) declare 2 objects. Use default and paremeter constructors


            // 9) do operations with books for all users: run all methods for both objects

            User1.AddBook("Project Management");
            User1.AddBook("Dorian Grey Portrait");
            User1.AddBook("No Town For An Old Man");
            User1.AddBook("Alice in Wonderland");
            User1.AddBook("The Old And The Sea");

            Console.WriteLine(User1.BooksCount());


            User1.RemoveBook("Alice in Wonderland");
            User1.RemoveBook("Math");
            //Console.WriteLine(User1.RemoveBook());

            Console.WriteLine("User First Name is {0} \n User Last Name {1} \n User ID {2}", User2.UserFirstName, User2.UserLastName, User2.userID);
            User2.AddBook("The Social Network");
            User2.RemoveBook("O Gehnri. Stories");

            User2.BookInfo(1);
            User2.BookInfo(2);

            Console.WriteLine(User2.BooksCount());
            
            Console.ReadKey();


        }
    }
}
