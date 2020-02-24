using CodeFirstDatabase.dbUtils;
using System;

namespace CodeFirstDatabase
{
    public class Program
    {
        static void Main(string[] args)
        {
            DatabaseFiller.CreateTables();
            Console.ReadLine();
        }

    }
}

