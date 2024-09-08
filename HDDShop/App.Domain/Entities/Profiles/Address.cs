using App.Domain.Entities.BaseData;
using System.ComponentModel.DataAnnotations;

namespace App.Domain.Entities.Profiles
{
    public class Address : BaseEntity
    {

        [Display(Name = "نام")]
        public string Name { get; set; }

        [Display(Name = "موقعیت نقشه")]
        public string Lan { get; set; }
        [Display(Name = "موقعیت نقشه")]
        public string Long { get; set; }
        [Display(Name = " شهر")]
        public int Cityid { get; set; }
        [Display(Name = "کد پستی")]
        public string PostalCode { get; set; }
        [Display(Name = " آدرس پیش فرض")]
        public bool IsDefault { get; set; } = true;
        [Display(Name = "ملیت")]
        public string? NationalId { get; set; }

        [Display(Name = "شرح")]
        public string Description { get; set; }
        [Display(Name = "کاربر")]
        public int UserId { get; set; }
    }
}
