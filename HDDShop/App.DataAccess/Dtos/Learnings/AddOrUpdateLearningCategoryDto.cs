using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DataAccess.Dtos.Learnings
{
    public class AddOrUpdateLearningCategoryDto
    {
        [Display(Name = "نام")]
        public string Name { get; set; }

        [Display(Name = "شرح")]
        public string? Discription { get; set; }


        [Display(Name = "عکس")]
        public string? Image { get; set; }
    }
}
