using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NurseryApplication1.Models
{
    public class Tree
    {
        [Key]
        public int TreeId { get; set; }
        public string TreeName { get; set; }
        //Height is in inches
        public int TreeHeight { get; set; }




        //A tree belongs to one categories
        //A categories can have many trees
        [ForeignKey("Categories")]
        public int CategoriesId { get; set; }
        public virtual Categories Categories { get; set; }
        public ICollection<Nurseryman> Nurserymen { get; set; }
    }

    public class TreeDto
    {
        public int TreeId { get; set; }
        public string TreeName { get; set; }

        //Height is in inches
        public int TreeHeight { get; set; }

        public int CategoriesId { get; set; }
        public string CategoriesName { get; set; }
    }
  

}