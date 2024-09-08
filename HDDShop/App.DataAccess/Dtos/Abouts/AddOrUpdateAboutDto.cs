﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DataAccess.Dtos.Abouts
{
    public class AddOrUpdateAboutDto
    {
        [Display(Name = "عنوان")]
        public string Title { get; set; }

        [Display(Name = "عکس")]
        public string? Image { get; set; }

        [Display(Name = "شرح")]
        public string Description { get; set; }
    }
}
