using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MIS4200Team8v2.Models
{
    public class userDetail
    {
        [Key]
        public int userID { get; set; }
        
        [Display (Name ="First Name")]
        [Required(ErrorMessage ="User first name required")]
        [StringLength(50)]

        public string firstName { get; set; }
        [Display (Name ="Last Name")]
        [Required(ErrorMessage ="User last name is required")]
        [StringLength(50)]
        public string lastName { get; set; }
        [Display (Name ="Work Email Address")]
        [Required]
        [EmailAddress(ErrorMessage ="Email address required")]
        [StringLength(100)]
        public string email { get; set; }
        [Display (Name ="Work or Mobile Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(\(\d{3}\) |\d{3}-)\d{3}-\d{4}$",
            ErrorMessage ="Phone number required")]
        public string phone { get; set; }
        [Display (Name ="Current Company Position")]
        [Required(ErrorMessage ="Current position title required")]
        

        public string positionTitle { get; set; }
        ICollection<sendPoints> sendPoints { get; set; }

    }
}