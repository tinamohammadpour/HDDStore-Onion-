using System.ComponentModel.DataAnnotations;

namespace App.Domain.Enums
{
    public enum Status
    {
        [Display(Name = "در حال ارسال")]
        Pending = 0,
        [Display(Name = "ارسال شده")]
        Sent = 1,
        [Display(Name = "ناموفق")]
        Failed = 2,
        [Display(Name = "دریافت شده")]
        Delivered = 3
    }
}
