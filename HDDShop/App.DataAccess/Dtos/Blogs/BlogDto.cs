using App.DataAccess.Dtos.Common;
using App.Domain.Entities.Blogs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DataAccess.Dtos.Blogs
{
    public class BlogDto: BaseDto
    {
        [Display(Name = "دسته بندی")]
        public  BlogCategoryDto BlogCategoryDto { get; set; }
        [Display(Name = "نام")]
        public string Name { get; set; }
        [Display(Name = "متن کوتاه")]
        public string ShortText { get; set; }
        [Display(Name = "شرح")]
        public string Description { get; set; }

    }
}
