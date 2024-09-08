using App.Domain.Entities.BaseData;
using App.Domain.Entities.Users;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Domain.Entities.Products
{
    public class Favorite : BaseEntity
    {

        [Display(Name = "عنوان")]
        public string Title { get; set; }

        [Display(Name = "عکس")]
        public string? Image { get; set; }

        [Display(Name = "متن کوتاه")]
        public string ShortText { get; set; }

        [Display(Name = "لینک کوتاه")]
        public string Shortlink { get; set; }

        [Display(Name = "کاربر")]
        public int UserId { get; set; }
        [Display(Name = "مبلغ کل")]
        public int Price { get; set; }

        #region MyRegion
        [ForeignKey(nameof(UserId))]
        public User User { get; set; }
        #endregion
    }
}
