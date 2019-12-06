using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using MIS4200Team8v2.Models;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace MIS4200Team8v2.Models
{
    public class coreValues
    {
        [Key]
        public int valueID { get; set; }
        [Display (Name = "Core Value")]
        public string valueName { get; set; }
        
        
        public string description { get; set; }


        ICollection<coreValues> CoreValues { get; set; }
    }
}