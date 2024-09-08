using System.ComponentModel.DataAnnotations;

namespace App.Domain.Enums
{
    public enum OrderStatus
    {
        [Display(Name = "معلق")]
        Pending = 0,
        [Display(Name = "تکمیل شده")]
        Completed = 1,
        [Display(Name = "تکمیل نشده")]
        NotCompleted = 2,
        [Display(Name = "بررسی مجدد")]
        ReView = 3,
        [Display(Name = "مرجوعی")]
        Return = 4,
        [Display(Name = "در حال ارسال")]
        Sending = 5

    }
}
