using CodeFirstDatabase.model;
using System.Data.Entity;

namespace CodeFirstDatabase.dbUtils
{
    public class DatasetContext : DbContext
    {
        public DbSet<Address> Addresses { get; set; }

        public DbSet<Author> Authors { get; set; }

        public DbSet<Book> Books { get; set; }

        public DbSet<BookStorage> BookStorages { get; set; }

        public DbSet<BorrowAgreement> BorrowAgreements { get; set; }

        public DbSet<DatabaseAdministrator> DatabaseAdministrators { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<Librarian> Librarians { get; set; }

        public DbSet<Reader> Readers { get; set; }

        public DbSet<User> Users { get; set; }

        public DatasetContext() : base("name=LibraryDB") { }
    }
}
