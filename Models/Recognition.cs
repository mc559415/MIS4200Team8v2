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
    public class Recognition
    {
        [Key]
        public int RecognitionID { get; set; }

        public Guid ID { get; set; }
        [ForeignKey(name:"ID")]
        public virtual userDetail userDetails { get; set; }

        [Required]
        [Display(Name = "Date of Recognition")]
        public DateTime DateofRecognition { get; set; }

        [Required]
        [Display(Name = "Core Value")]
        public coreValues award { get; set; }

        public enum corevalues
        {
            Excellence = 1,
            Culture = 2,
            Integrity = 3,
            Stewardship = 4,
            Innovate = 5,
            Passion = 6,
            Balance = 7

        }
    }
    }
