﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstDatabase.model
{
    [Table("BookStorages")]
    public class BookStorage
    {
        [Key]
        public int BookStorageId { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }
    }
}
