using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SkillTree_MVC_Homework_1.Models.ViewModels
{
    public class DetailsViewModel
    {
        public string Category { get; set; }

        [DisplayFormat(DataFormatString = "{0:N0}")]
        public decimal Amount { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime Date { get; set; }

        public string Description { get; set; }
    }
}