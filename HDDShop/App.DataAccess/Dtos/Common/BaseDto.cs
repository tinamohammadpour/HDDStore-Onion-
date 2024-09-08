using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DataAccess.Dtos.Common
{
    public class BaseDto
    {
        [Display(Name ="#")]
        public int Id { get; set; }
    }
}
