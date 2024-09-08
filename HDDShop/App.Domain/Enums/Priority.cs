using System.ComponentModel.DataAnnotations;

namespace App.Domain.Enums
{
    public enum Priority
    {

        [Display(Name = "کم")]
        Low = 0,
        [Display(Name = "زیاد")]
        High = 1,
        [Display(Name = "متوسط")]
        Medium = 2
    }
}

