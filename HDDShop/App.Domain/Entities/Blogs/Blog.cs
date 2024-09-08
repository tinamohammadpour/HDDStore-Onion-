using App.Domain.Entities.BaseData;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Domain.Entities.Blogs
{
    public class Blog:BaseEntity
    {
        [Display(Name = "دسته بندی")]
        public int BlogCategoryId { get; set; }
        [Display(Name = "نام")]
        public string Name { get; set; }
        [Display(Name = "متن کوتاه")]
        public string ShortText { get; set; }
        [Display(Name = "شرح")]
        public string Description { get; set; }


        [ForeignKey(nameof(BlogCategoryId))]
        public BlogCategory BlogCategory { get; set; }



    }
}
