using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NurseryApplication1.Models.ViewModels
{
    public class UpdateTree
    {
        //This viewmodel is a class which stores information that we need to present to /Animal/Update/{}

        //the existing animal information

        public TreeDto SelectedTree { get; set; }

        // all species to choose from when updating this animal

        public IEnumerable<CategoriesDto> CategoriesOptions { get; set; }
    }
}