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
              
                    BookStorage bookStorage_0 = new BookStorage
                    {
                        BookStorageName = "Magazyn-0"
                    };
                    objects.Add(bookStorage_0);
                    BookStorage bookStorage_1 = new BookStorage
                    {
                        BookStorageName = "Magazyn-1"
                    };
                    objects.Add(bookStorage_1);
                    
                    Author author_0 = new Author
                    {
                        AuthorName = "test0",
                        AuthorSurname = "testowy0"
                    };
                    objects.Add(author_0);
                    Author author_1 = new Author
                    {
                        AuthorName = "test1",
                        AuthorSurname = "testowy1"
                    };
                    objects.Add(author_1);
                    Author author_2 = new Author
                    {
                        AuthorName = "test2",
                        AuthorSurname = "testowy2"
                    };
                    objects.Add(author_2);

                    Genre genre_0 = new Genre
                    {
                        GenreName = "genre_test_0"
                    };
                    objects.Add(genre_0);
                    Genre genre_1 = new Genre
                    {
                        GenreName = "genre_test_1"
                    };
                    objects.Add(genre_1);

                    Book book_0 = new Book
                    {
                        BookName = "test_0",
                        BookPubYear = 1970,
                        BookGenre = genre_0,
                        BookStorage = bookStorage_0
                    };
                    BookAuthor bookAuthor_0 = new BookAuthor
                    {
                        Book = book_0,
                        Author = author_0
                    };
                    BookAuthor bookAuthor_1 = new BookAuthor
                    {
                        Book = book_0,
                        Author = author_1
                    };
                    book_0.AuthorsRef.Add(bookAuthor_0);
                    book_0.AuthorsRef.Add(bookAuthor_1);
                    author_0.BooksRef.Add(bookAuthor_0);
                    author_1.BooksRef.Add(bookAuthor_1);
                    objects.Add(book_0);

                    Book book_1 = new Book
                    {
                        BookName = "test_1",
                        BookPubYear = 1980,
                        BookGenre = genre_1,
                        BookStorage = bookStorage_1
                    };
                    BookAuthor bookAuthor_3 = new BookAuthor
                    {
                        Book = book_1,
                        Author = author_2
                    };
                    book_1.AuthorsRef.Add(bookAuthor_3);
                    author_2.BooksRef.Add(bookAuthor_3);
                    objects.Add(book_1);

                    Book book_2 = new Book
                    {
                        BookName = "test_2",
                        BookPubYear = 1985,
                        BookGenre = genre_0,
                        BookStorage = bookStorage_1
                    };
                    BookAuthor bookAuthor_4 = new BookAuthor
                    {
                        Book = book_2,
                        Author = author_0
                    };
                    BookAuthor bookAuthor_5 = new BookAuthor
                    {
                        Book = book_2,
                        Author = author_2
                    };
                    book_2.AuthorsRef.Add(bookAuthor_4);
                    book_2.AuthorsRef.Add(bookAuthor_5);
                    author_0.BooksRef.Add(bookAuthor_4);
                    author_2.BooksRef.Add(bookAuthor_5);
                    objects.Add(book_2);

                    Book book_3 = new Book
                    {
                        BookName = "test_3",
                        BookPubYear = 1990,
                        BookGenre = genre_1,
                        BookStorage = bookStorage_0
                    };
                    BookAuthor bookAuthor_6 = new BookAuthor
                    {
                        Book = book_3,
                        Author = author_1
                    };
                    BookAuthor bookAuthor_7 = new BookAuthor
                    {
                        Book = book_3,
                        Author = author_2
                    };
                    book_3.AuthorsRef.Add(bookAuthor_6);
                    book_3.AuthorsRef.Add(bookAuthor_7);
                    author_1.BooksRef.Add(bookAuthor_6);
                    author_2.BooksRef.Add(bookAuthor_7);
                    objects.Add(book_3);

                    Book book_4 = new Book
                    {
                        BookName = "test_4",
                        BookPubYear = 1995,
                        BookGenre = genre_0,
                        BookStorage = bookStorage_1
                    };
                    BookAuthor bookAuthor_8 = new BookAuthor
                    {
                        Book = book_4,
                        Author = author_1
                    };
                    book_4.AuthorsRef.Add(bookAuthor_8);
                    author_1.BooksRef.Add(bookAuthor_8);
                    objects.Add(book_4);
                    
                    Address address_0 = new Address
                    {
                        ZipCode = "00-111",
                        CityName = "testowo_0",
                        StreetName = "testowa_0"
                    };
                    objects.Add(address_0);
                    Address address_1 = new Address
                    {
                        ZipCode = "00-222",
                        CityName = "testowo_1",
                        StreetName = "testowa_1"
                    };
                    objects.Add(address_1);
                    Address address_2 = new Address
                    {
                        ZipCode = "00-111",
                        CityName = "testowo_0",
                        StreetName = "testowa_1"
                    };
                    objects.Add(address_2);
                    Address address_3 = new Address
                    {
                        ZipCode = "00-222",
                        CityName = "testowo_1",
                        StreetName = "testowa_2"
                    };
                    objects.Add(address_3);

                    User user_0 = new User
                    {
                        UserLogin = "test",
                        UserPassword = "123456",
                        Role = RoleEnum.Reader,
                        RoleID = 1
                    };
                    objects.Add(user_0);
                    User user_1 = new User
                    {
                        UserLogin = "test2",
                        UserPassword = "123456",
                        Role = RoleEnum.Reader,
                        RoleID = 2
                    };
                    objects.Add(user_1);
                    User user_2 = new User
                    {
                        UserLogin = "admin",
                        UserPassword = "123456",
                        Role = RoleEnum.DatabaseAdministrator,
                        RoleID = 1
                    };
                    objects.Add(user_2);
                    User user_3 = new User
                    {
                        UserLogin = "test3",
                        UserPassword = "123456",
                        Role = RoleEnum.Librarian,
                        RoleID = 1
                    };
                    objects.Add(user_3);

                    Reader reader_0 = new Reader
                    {
                        ReaderName = "test_0",
                        ReaderSurname = "testowy_0",
                        ReaderPenalty = 0,
                        ReaderPhoneNumber = "000000000",
                        ReaderAdress = address_0,
                        UserAccount = user_0
                    };
                    objects.Add(reader_0);
                    Reader reader_1 = new Reader
                    {
                        ReaderName = "test_1",
                        ReaderSurname = "testowy_1",
                        ReaderPenalty = -200,
                        ReaderPhoneNumber = "000111000",
                        ReaderAdress = address_1,
                        UserAccount = user_1
                    };
                    objects.Add(reader_1);

                    Librarian librarian_0 = new Librarian
                    {
                        LibrarianName = "test_0",
                        LibrarianSurname = "testowy_0",
                        LibrarianAdress = address_2,
                        LibrarianPhoneNumber = "111000111",
                        LibrarianSalary = 2500,
                        UserAccount = user_3
                    };
                    objects.Add(librarian_0);

                    DatabaseAdministrator dbAdmin_0 = new DatabaseAdministrator
                    {
                        AdminName = "test_0",
                        AdminSurname = "testowy_0",
                        AdminPhoneNumber = "222111222",
                        UserAccount = user_2
                    };
                    objects.Add(dbAdmin_0);
                    
                    BorrowAgreement borrowAgreement_0 = new BorrowAgreement
                    {
                        BorrowedBook = book_0,
                        Borrower = reader_0,
                        ReturnDate = new DateTime(2020, 4, 12),
                        IsActive = true
                    };
                    book_0.BorrowAgreements.Add(borrowAgreement_0);
                    reader_0.BorrowAgreements.Add(borrowAgreement_0);
                    objects.Add(borrowAgreement_0);

                    BorrowAgreement borrowAgreement_1 = new BorrowAgreement
                    {
                        BorrowedBook = book_1,
                        Borrower = reader_1,
                        ReturnDate = new DateTime(2020, 3, 11),
                        IsActive = false
                    };
                    book_1.BorrowAgreements.Add(borrowAgreement_1);
                    reader_1.BorrowAgreements.Add(borrowAgreement_1);
                    objects.Add(borrowAgreement_1);

                    BorrowAgreement borrowAgreement_2 = new BorrowAgreement
                    {
                        BorrowedBook = book_2,
                        Borrower = reader_1,
                        ReturnDate = new DateTime(2020, 3, 11),
                        IsActive = true
                    };
                    book_2.BorrowAgreements.Add(borrowAgreement_2);
                    reader_1.BorrowAgreements.Add(borrowAgreement_2);
                    objects.Add(borrowAgreement_2);

                    
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
