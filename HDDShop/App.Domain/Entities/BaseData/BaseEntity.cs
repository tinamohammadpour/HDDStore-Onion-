using System.ComponentModel.DataAnnotations;

namespace App.Domain.Entities.BaseData
{
    public class BaseEntity
    {
        [Key]
        [Display(Name = "#")]
        public int Id { get; set; }

        [Display(Name = "تاریخ ساخت")]
        public DateTime CreateAt { get; set; } = DateTime.Now;

        [Display(Name = "تاریخ ویرایش")]
        public DateTime UpdateAt { get; set; } = DateTime.Now;
    }
}
