using System.ComponentModel.DataAnnotations;

namespace App.Domain.Entities.Massages
{
    public class PushNotification : BaseDataMessage
    {

        [Display(Name = "#")]
        public Guid Token { get; set; }

        [Display(Name = "آیکون")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string Icon { get; set; } = "E:\\Shareghi\\HardShop\\DesignClubDb\\wwwroot\\favicon.ico";


    }
}
