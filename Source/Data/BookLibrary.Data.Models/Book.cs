﻿namespace BookLibrary.Data.Models
{
    using BookLibrary.Data.Common.Models;
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Book : AuditInfo, IDeletableEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [MaxLength(300)]
        public string Description { get; set; }

        public bool IsAvailable { get; set; }

        public string RentedBy { get; set; }

        public string LastRenter { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
