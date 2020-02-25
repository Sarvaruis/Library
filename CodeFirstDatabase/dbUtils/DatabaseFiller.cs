using CodeFirstDatabase.model;
using System.Linq;
using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace CodeFirstDatabase.dbUtils
{
    public class DatabaseFiller
    {
        public static void CreateTables()
        {
            try
            {
                using (var context = new DatasetContext())
                {
                    /* creating some sample data */
                    List<Object> objects = new List<object>();
              
                    var bookStorage0 = new BookStorage
                    {
                        Name = "bookStorageName0"
                    };
                    objects.Add(bookStorage0);
                    var bookStorage1 = new BookStorage
                    {
                        Name = "bookStorageName1"
                    };
                    objects.Add(bookStorage1);
                    
                    var author0 = new Author
                    {
                        Name = "authorName0",
                        Surname = "authorSurname0"
                    };
                    objects.Add(author0);
                    var author1 = new Author
                    {
                        Name = "authorName1",
                        Surname = "authorSurname1"
                    };
                    objects.Add(author1);
                    var author2 = new Author
                    {
                        Name = "authorName2",
                        Surname = "authorSurname2"
                    };
                    objects.Add(author2);

                    var genre0 = new Genre
                    {
                        Name = "genreName0"
                    };
                    objects.Add(genre0);
                    var genre1 = new Genre
                    {
                        Name = "genreName1"
                    };
                    objects.Add(genre1);

                    var book0 = new Book
                    {
                        Name = "bookName0",
                        PubYear = 1970,
                        Genre = genre0,
                        BookStorage = bookStorage0
                    };
                    objects.Add(book0);
                    var book1 = new Book
                    {
                        Name = "bookName1",
                        PubYear = 1980,
                        Genre = genre1,
                        BookStorage = bookStorage1
                    };
                    objects.Add(book1);
                    var book2 = new Book
                    {
                        Name = "bookName2",
                        PubYear = 1985,
                        Genre = genre0,
                        BookStorage = bookStorage1
                    };
                    objects.Add(book2);
                    var book3 = new Book
                    {
                        Name = "bookName3",
                        PubYear = 1990,
                        Genre = genre1,
                        BookStorage = bookStorage0
                    };
                    objects.Add(book3);
                    var book4 = new Book
                    {
                        Name = "bookName4",
                        PubYear = 1995,
                        Genre = genre0,
                        BookStorage = bookStorage1
                    };
                    objects.Add(book4);

                    var bookAuthor = new BookAuthor
                    {
                        Book = book0,
                        Author = author0
                    };
                    objects.Add(bookAuthor);
                    bookAuthor = new BookAuthor
                    {
                        Book = book0,
                        Author = author1
                    };
                    objects.Add(bookAuthor);
                    bookAuthor = new BookAuthor
                    {
                        Book = book0,
                        Author = author2
                    };
                    objects.Add(bookAuthor);
                    bookAuthor = new BookAuthor
                    {
                        Book = book1,
                        Author = author2
                    };
                    objects.Add(bookAuthor);
                    bookAuthor = new BookAuthor
                    {
                        Book = book2,
                        Author = author0
                    };
                    objects.Add(bookAuthor);
                    bookAuthor = new BookAuthor
                    {
                        Book = book2,
                        Author = author2
                    };
                    objects.Add(bookAuthor);
                    bookAuthor = new BookAuthor
                    {
                        Book = book3,
                        Author = author1
                    };
                    objects.Add(bookAuthor);
                    bookAuthor = new BookAuthor
                    {
                        Book = book3,
                        Author = author2
                    };
                    objects.Add(bookAuthor);
                    bookAuthor = new BookAuthor
                    {
                        Book = book4,
                        Author = author1
                    };
                    objects.Add(bookAuthor);

                    var address0 = new Address
                    {
                        ZipCode = "00-111",
                        CityName = "cityName0",
                        StreetName = "streetName0"
                    };
                    objects.Add(address0);
                    var address1 = new Address
                    {
                        ZipCode = "00-222",
                        CityName = "cityName1",
                        StreetName = "streetName1"
                    };
                    objects.Add(address1);
                    var address2 = new Address
                    {
                        ZipCode = "00-111",
                        CityName = "cityName2",
                        StreetName = "streetName2"
                    };
                    objects.Add(address2);
                    var address3 = new Address
                    {
                        ZipCode = "00-222",
                        CityName = "cityName3",
                        StreetName = "streetName3"
                    };
                    objects.Add(address3);

                    var user0 = new User
                    {
                        Login = "test",
                        Password = "123456"
                    };
                    objects.Add(user0);
                    var user1 = new User
                    {
                        Login = "test2",
                        Password = "123456"
                    };
                    objects.Add(user1);
                    var user2 = new User
                    {
                        Login = "admin",
                        Password = "123456"
                    };
                    objects.Add(user2);
                    var user3 = new User
                    {
                        Login = "test3",
                        Password = "123456"
                    };
                    objects.Add(user3);

                    var reader0 = new Reader
                    {
                        Name = "readerName0",
                        Surname = "readerSurname0",
                        Penalty = 0,
                        PhoneNumber = "000000000",
                        Adress = address0,
                        UserAccount = user0
                    };
                    objects.Add(reader0);
                    var reader1 = new Reader
                    {
                        Name = "readerName1",
                        Surname = "readerSurname1",
                        Penalty = -200,
                        PhoneNumber = "000111000",
                        Adress = address1,
                        UserAccount = user1
                    };
                    objects.Add(reader1);

                    var librarian = new Librarian
                    {
                        Name = "librarianName0",
                        Surname = "librarianSurname",
                        Address = address2,
                        PhoneNumber = "111000111",
                        Salary = 2500,
                        UserAccount = user3
                    };
                    objects.Add(librarian);

                    var dbAdmin = new DatabaseAdministrator
                    {
                        Name = "adminName0",
                        Surname = "adminSurname0",
                        PhoneNumber = "222111222",
                        UserAccount = user2
                    };
                    objects.Add(dbAdmin);
                    
                    var borrowAgreement = new BorrowAgreement
                    {
                        BorrowedBook = book0,
                        Borrower = reader0,
                        ReturnDate = new DateTime(2020, 4, 12),
                        IsActive = true
                    };
                    objects.Add(borrowAgreement);
                    borrowAgreement = new BorrowAgreement
                    {
                        BorrowedBook = book1,
                        Borrower = reader1,
                        ReturnDate = new DateTime(2020, 3, 11),
                        IsActive = false
                    };
                    objects.Add(borrowAgreement);
                    borrowAgreement = new BorrowAgreement
                    {
                        BorrowedBook = book2,
                        Borrower = reader1,
                        ReturnDate = new DateTime(2020, 3, 11),
                        IsActive = true
                    };
                    objects.Add(borrowAgreement);

                    
                    /* adding sample data to context */

                    foreach (var obj in objects)
                    {
                        switch (obj.GetType().Name)
                        {
                            case "Address":
                                context.Addresses.Add((Address)obj);
                                break;
                            case "Author":
                                context.Authors.Add((Author)obj);
                                break;
                            case "Book":
                                context.Books.Add((Book)obj);
                                break;
                            case "BookAuthor":
                                context.BooksAuthors.Add((BookAuthor)obj);
                                break;
                            case "BookStorage":
                                context.BookStorages.Add((BookStorage)obj);
                                break;
                            case "BorrowAgreement":
                                context.BorrowAgreements.Add((BorrowAgreement)obj);
                                break;
                            case "DatabaseAdministrator":
                                context.DatabaseAdministrators.Add((DatabaseAdministrator)obj);
                                break;
                            case "Genre":
                                context.Genres.Add((Genre)obj);
                                break;
                            case "Librarian":
                                context.Librarians.Add((Librarian)obj);
                                break;
                            case "Reader":
                                context.Readers.Add((Reader)obj);
                                break;
                            case "User":
                                context.Users.Add((User)obj);
                                break;
                        }
                    }
                    context.SaveChanges();
                    Console.WriteLine("Database fillment task is complete. Press any key to continue...");
                }
            }
            catch (SqlException)
            {
                Console.WriteLine("Connection error has occured.");
            }
        }
    }
}
