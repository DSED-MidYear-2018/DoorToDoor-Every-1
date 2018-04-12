using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace DoorToDoor_Every_1.Models
{
    public class Admin
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }



        //[Display(Name = "Remember me?")]
        //public bool RememberMe { get; set; }


        //Foreign Key
        [Display(Name = "AdminRole")]
        public int AdminRoleId { get; set; }

        [ForeignKey("AdminRoleId")]
        public virtual AdminRole AdminRoles { get; set; }

        //[Required]
        //[EmailAddress]
        //[Display(Name = "Email")]
        public string Email { get; set; }

        //[Required]
        //[StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        //[DataType(DataType.Password)]
        //[Display(Name = "Password")]
        public string Password { get; set; }

        //[DataType(DataType.Password)]
        //[Display(Name = "Confirm password")]
        //[Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        //public string ConfirmPassword { get; set; }
    }
}

