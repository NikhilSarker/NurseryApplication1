using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NurseryApplication1.Models
{
    public class Nurseryman
    {
        [Key]
        public int NurserymanId { get; set; }
        public string NurserymanFirstName { get; set; }
        public string NurserymanLastName { get; set; }

        // A nurseryman can take care many trees

        public ICollection<Tree> Trees { get; set; }
    }
}