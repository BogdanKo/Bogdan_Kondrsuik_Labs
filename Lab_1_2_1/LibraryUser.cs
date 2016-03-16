using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_2_1_lab
{




    /*Goal: Getting a practical experience in classes, objects, constructors, properties, indexers, interfaces
Task: Develop program, that simulate library activity.

Declare interface ILibraryUser with methods AddBook(), RemoveBook(), BookInfo(), BooksCount()

        Delcare class LibraryUser, it implements ILibraryUser. Members: 
properties FirstName (read only), LastName (read only), Id (read only), Phone (get and set), BookLimit (read only);
field bookList (private string array);

        Indexer BookList (for array bookList);
Constructors – default and parameter;

        Methods AddBook() – add new book to array bookList, RemoveBook() – remove book from array bookList, BookInfo() – returns book info by index, BooksCout() – returns current count of books

        Declare 2 objects: user1, user2 (use default constructor, parameter constructor).

        Do all operations for every user*/

    // 1) declare interface ILibraryUser

    public interface ILibraryUser
    {

        void AddBook(string adding_book_name);
        void RemoveBook(string removing_book_name);
        void BookInfo(string book_name_by_index);
        int BooksCount();
    }

    // declare method's signature for methods of class LibraryUser


    // 2) declare class LibraryUser, it implements ILibraryUser
    public class LibraryUser : ILibraryUser
    {




        static public int bookscount = 9;
        private const int bufferSizeForBookList = 9;
        private string[] bookList = new string[bufferSizeForBookList];
        int currentBook = 0;


        private string user_First_Name;
        private string user_Last_Name;
        private string user_ID;
        private int phoneNumber;
        private int bookLimit;

        //Phone(get and set), BookLimit(read only);
        //field bookList(private string array);
        // 6) declare constructors: default 

        public LibraryUser() { }

        // 3) declare properties: FirstName (read only), LastName (read only), 

        public string UserFirstName { get { return user_First_Name; } set { } }

        public string UserLastName { get { return user_Last_Name; } set { } }

        public string userID { get { return user_ID; } }

        public int UserphNumber { get { return phoneNumber; } set { } }

        public int BookLimit { get { return bookLimit; } }

        //  and parameter

        public LibraryUser(string firstName, string lastName, string Id, int userPhoneNumber, int bookLim)
        {
            user_First_Name = firstName;
            user_Last_Name = lastName;
            user_ID = Id;
            phoneNumber = userPhoneNumber;
            bookLim = bookLimit;

        }



        // Id (read only), Phone (get and set), BookLimit (read only)




        // 4) declare field (bookList) as a string array


        // 5) declare indexer BookList for array bookList

        public string this[int BookList]
        {
            get
            {
                string temp;
                if (BookList >= 0 && BookList <= bookscount - 1)


                { temp = this.bookList[BookList]; }

                else
                { temp = ""; }
                return temp;

            }
            set
            {

                if (BookList >= 0 && BookList <= bookscount - 1)
                {
                    bookList[BookList] = value;
                }
            }
        }



        // 7) declare methods: 
        //AddBook() – add new book to array bookList,

        public void AddBook(string adding_book_name)

        {
            string[] tempArr = new string[bookList.Length + bufferSizeForBookList];

            if (bookList.Length <= bookscount)
            {

                for (int i = 0; i < bookList.Length; i++)
                {

                    tempArr[i] = bookList[i];
                }
                bookList = tempArr;
            }
            bookList[currentBook++] = adding_book_name;
            Console.WriteLine(adding_book_name);
        }



        //RemoveBook() – remove book from array bookList,
        public void RemoveBook(string removing_book_name)
        {

            for (int i = 0; i <= bookList.Length; i++)
                if (bookList[i] == removing_book_name)
                {
                    string tempRemoveBookName = bookList[i];
                    for (int j = i; j <= bookList.Length - 1; j++)
                    {
                        bookList[j] = bookList[j - 1];

                    }
                    Console.WriteLine(tempRemoveBookName);
                    currentBook--;
                    break;
                }
                else if (i >= bookList.Length - 1)
                    Console.WriteLine(removing_book_name);

        }



        //bookList[currentBook--] = removing_book_name;
        //Console.WriteLine(removing_book_name);


        //BookInfo() – returns book info by index,
        public void BookInfo(int book_info_by_index)

        {

            if (book_info_by_index >= 0 && book_info_by_index <= bookList.Length)
                Console.WriteLine("Book name is {0}", bookList[book_info_by_index]);
            
        }

           
        //BooksCout() – returns current count of books
        public int BooksCount()
        {
            
            while (bookList[currentBook] != null)
            {
                currentBook++;
            }
            return currentBook;

        }


    

    }
}
