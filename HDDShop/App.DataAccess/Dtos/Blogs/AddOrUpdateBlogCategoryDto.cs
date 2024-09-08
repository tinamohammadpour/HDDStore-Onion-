using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DataAccess.Dtos.Blogs
{
    public class AddOrUpdateBlogCategoryDto
    {
        [Display(Name = "نام")]
        public string Name { get; set; }
        [Display(Name = "شرح")]
        public string? Description { get; set; }
    }
}
