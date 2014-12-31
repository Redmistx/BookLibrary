using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookLibrary.Web.InputModels
{
    public class BookInputModel
    {
        public string Name { get; set; }

        public string Description { get; set; }
    }
}