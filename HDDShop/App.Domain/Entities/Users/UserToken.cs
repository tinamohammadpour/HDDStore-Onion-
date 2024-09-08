using App.Domain.Entities.BaseData;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Domain.Entities.Users
{
    public class UserToken : BaseEntity
    {


        [Required]
        [MaxLength(13)]
        [MinLength(11)]
        public string PhoneNumber { get; set; }

        public int UserId { get; set; }

        [Required]
        public string Token { get; set; }

        public bool IsAcvtive { get; set; } = true;

        public DateTime ExpireDate { get; set; } = DateTime.Now.AddDays(10);


        #region MyRegion
        [ForeignKey(nameof(UserId))]
        public User User { get; set; }
        #endregion
    }
}
