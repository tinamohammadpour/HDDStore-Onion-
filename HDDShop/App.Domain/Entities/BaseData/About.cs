using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Entities.BaseData
{
    public class About: BaseEntity
    {

        [Display(Name ="عنوان")]
        public string Title { get; set; }

        [Display(Name = "عکس")]
        public string? Image { get; set; }

        [Display(Name ="شرح")]
        public string Description { get; set; }
    }
}
