using BookLibrary.Data.Models;
using BookLibrary.Web.Infrastructure.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookLibrary.Web.ViewModels.Home
{
    public class BookViewModel : IMapFrom<Book>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool IsAvailable { get; set; }

        public string RentedBy { get; set; }

        public string LastRenter { get; set; }
    }
}