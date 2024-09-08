using App.Domain.Entities.BaseData;
using System.ComponentModel.DataAnnotations;

namespace App.Domain.Entities.Blogs
{
    public class BlogCategory:BaseEntity
    {

        [Display(Name = "نام")]
        public string Name { get; set; }
        [Display(Name = "شرح")]
        public string? Description { get; set; }


        public ICollection<Blog> Blogs { get; set; }

    }
}
