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
    public class sendPoints
    {
        [Key]
        public int pointsID { get; set; }
        [Display(Name = "User")]
        public Guid userID { get; set; }

        public virtual userDetail UserDetail { get; set; }
        [Display(Name = "Core Value")]
        [Required(ErrorMessage = "Must Select a Value")]
        public int valueID { get; set; }

        public virtual coreValues CoreValues { get; set; }
        [Display(Name = "Point Value")]
        public int PointValue { get; set; }
        [Required]
        [Display(Name = "Time of Recognition")]
        
        public DateTime recognitionTime { get; set; }
        [Display(Name ="Description")]
        public string description { get; set; }


    }
}