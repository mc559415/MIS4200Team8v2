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
        [Required]
        public int userID { get; set; }
        [ForeignKey("userID")]
        [Required]
        [Display(Name = "First Name")]
        public string firstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string lastName { get; set; }
        [Required]
        [Display(Name = "Core Value")]
        public string coreValue { get; set; }
        [Required]
        [Display(Name = "Points")]
        public int points { get; set; }
       
        public virtual UserDetail UserDetail { get; set; }
    }
}