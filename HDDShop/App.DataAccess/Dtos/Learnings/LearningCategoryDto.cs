using App.DataAccess.Dtos.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DataAccess.Dtos.Learnings
{
    public class LearningCategoryDto:BaseDto
    {
        [Display(Name = "نام")]
        public string Name { get; set; }

        [Display(Name = "شرح")]
        public string? Discription { get; set; }


        [Display(Name = "عکس")]
        public string? Image { get; set; }
    }
}
