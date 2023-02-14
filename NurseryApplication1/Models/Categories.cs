using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NurseryApplication1.Models
{
    public class Categories
    {
        [Key]
        public int CategoriesId { get; set; }

        public string CategoriesName { get; set; }
    }

  


   public class CategoriesDto

   {
    public int CategoriesId { get; set; }
    public string CategoriesName { get; set; }

   }
}