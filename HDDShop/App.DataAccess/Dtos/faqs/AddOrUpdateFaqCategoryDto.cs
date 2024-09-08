using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DataAccess.Dtos.faqs
{
    public class AddOrUpdateFaqCategoryDto
    {

        [Display(Name = "عنوان")]
        public string Name { get; set; }



        [Display(Name = "تصویر")]
        public string? Image { get; set; }
    }
}
