using App.Domain.Entities.BaseData;
using App.Domain.Entities.Users;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Domain.Entities.Massages
{
    public class SmsCode : BaseEntity
    {



        [Display(Name = "شماره تلفن")]
        [Required]
        [MaxLength(13)]
        [MinLength(11)]
        public string PhoneNumber { get; set; }

        [Display(Name = "کاربر")]
        public int UserId { get; set; }

        [Display(Name = "کد")]
        [Required]
        [MaxLength(4)]
        public string Code { get; set; }


        [Display(Name = "تاریخ انقضا")]
        public DateTime ExpireDate { get; set; } = DateTime.Now.AddMinutes(2);


        [Display(Name = "تعداد")]
        public int Count { get; set; } = 1;

        #region MyRegion
        [ForeignKey(nameof(UserId))]
        public User User { get; set; }
        #endregion
    }
}
