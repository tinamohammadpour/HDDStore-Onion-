using System.ComponentModel.DataAnnotations;

namespace App.Domain.Enums
{
    public enum PaymentResult
    {
        [Display(Name = "موفقیت آمیز")]
        Success = 0,
        [Display(Name = "ناموفق")]
        Failed = 1,
        [Display(Name = "در حال انجام")]
        Pending = 2
    }
}
