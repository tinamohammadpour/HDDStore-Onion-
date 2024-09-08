using App.Domain.Entities.BaseData;
using System.ComponentModel.DataAnnotations;

namespace App.Domain.Entities.Roles
{
    public class Role : BaseEntity
    {

        [Display(Name = "نام")]
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

        #region MyRegion
        public ICollection<UserRole> Roles { get; set; }
        #endregion

    }
}
