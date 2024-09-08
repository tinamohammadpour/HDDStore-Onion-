using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DataAccess.Dtos.Learnings
{
    public class AddOrUpdateLearningDto
    {
        [Display(Name = "ویدیو")]
        public string? Video { get; set; }

        [Display(Name = "عکس")]
        public string? Image { get; set; }

        [Display(Name = "عنوان")]
        public string Title { get; set; }

        [Display(Name = "متن")]
        public string Text { get; set; }

        [Display(Name = "دسته بندی")]
        public int LearningCategoryId { get; set; }
    }
}
