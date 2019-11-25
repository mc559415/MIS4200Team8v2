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
        public Guid userID { get; set; }
        public virtual userDetail UserDetail { get; set; }
        public int valueID { get; set; }
        public virtual coreValues CoreValues { get; set; }
        public int PointValue { get; set; }
    }
}