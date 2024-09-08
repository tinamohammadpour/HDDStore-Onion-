using App.Domain.Entities.BaseData;
using App.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace App.Domain.Entities.Orders
{
    public class OrderDetail:BaseEntity
    {
        [Display(Name = "نام کامل")]
        [Required]
        [MaxLength(25)]
        public string FullName { get; set; }

        [Display(Name = "کدملی")]
        [Required]
        [StringLength(10)]
        public string MelliCode { get; set; }


        [Display(Name = "شهر")]
        [Required]
        public int CityId { get; set; }

        [Display(Name = "کدپستی")]
        [Required]
        [StringLength(10)]
        public string PostalNumber { get; set; }


        [Display(Name = "شماره تلفن")]
        [Required]
        [MaxLength(13)]
        [MinLength(11)]
        public string PhoneNumber { get; set; }

        [Display(Name = "ایمیل")]
        public string? Email { get; set; }

        [Display(Name = "پرتال")]

        public portal Portal { get; set; }


    }

}
