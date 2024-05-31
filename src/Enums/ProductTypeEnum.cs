using System.ComponentModel.DataAnnotations;
using System;

namespace ContosoCrafts.WebSite.Models
{
    /// <summary>
    /// Defines an enum for the different types
    /// </summary>
    public enum ProductTypeEnum
    {
        // Adding categories for ProductType list displayed on update page for admin to choose from
        [Display(Name = "Non-dairy")] nondairy = 0,
        [Display(Name = "dairy")] dairy = 1,
        [Display(Name = "vegan")] vegan = 2,
        [Display(Name = "protein")] protein = 3,

    }
}


