using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DataAccess.Dtos.Blogs
{
    public class AddorUpdateBlogDto
    {
        [Display(Name = "دسته بندی")]
        public int BlogCategoryId { get; set; }

        [Display(Name = "نام")]
        public string Name { get; set; }

        [Display(Name = "متن کوتاه")]
        public string ShortText { get; set; }

        [Display(Name = "شرح")]
        public string Description { get; set; }
    }
}
