using App.Domain.Entities.BaseData;
using System.ComponentModel.DataAnnotations;

namespace App.Domain.Entities.Profiles
{
    public class OrderList:BaseEntity
    {
        [Display(Name = "عنوان")]
        public string Title { get; set; }
        [Display(Name = "عکس")]
        public string? Image { get; set; }

        [Display(Name = "متن کوتاه")]
        public string ShortText { get; set; }

        [Display(Name = "لینک کوتاه")]
        public string Shortlink { get; set; }

        [Display(Name = "مبلغ")]
        public int Price { get; set; }
    }
}
