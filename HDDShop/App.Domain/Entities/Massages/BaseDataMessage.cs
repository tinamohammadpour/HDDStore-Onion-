using App.Domain.Entities.BaseData;
using App.Domain.Entities.Users;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace App.Domain.Entities.Massages
{
    public class BaseDataMessage : BaseEntity
    {
        [Display(Name = "عنوان")]
        [MaxLength(100, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string? title { get; set; }


        [Display(Name = "پیام")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(300, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string Massage { get; set; }
        [Display(Name = "کاربر")]
        public int UserId { get; set; }

        [Display(Name = "وضعیت")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public Enums.Status Status { get; set; }

        [Display(Name = "تایم ارسال")]
        [DisplayFormat(DataFormatString = "{0:hh:mm}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public DateTime SendTime { get; set; }
        [Display(Name = "تایم دریافت")]
        [DisplayFormat(DataFormatString = "{0:hh:mm}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public DateTime DeliveredTime { get; set; }


        [Display(Name = "لینک")]
        [MaxLength(400, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string? link { get; set; }
        [Display(Name = "اولویت")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public Enums.Priority Priority { get; set; } = Enums.Priority.Medium;


        #region Relation
        [ForeignKey(nameof(UserId))]
        public User User { get; set; }
        #endregion
    }



}
