using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Candy_SUT21.Models
{
    public class Order
    {
        [Key]
        [BindNever]
        public int OrderID { get; set; }

        [Required (ErrorMessage = "Please enter your First name.")]
        [Display(Name = "First Name")]
        [StringLength(50)]
        public string FirstName { get; set; }
        
        [Required(ErrorMessage = "Please enter your Last name.")]
        [Display(Name = "Last Name")]
        [StringLength (50)]
        public string LastName { get; set; }
        
        [Required(ErrorMessage = "Please enter your Email.")]
        [Display(Name = "Email")]
        [StringLength(100)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your Street Address.")]
        [Display(Name = "Street Address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please enter the name of your City.")]
        [Display(Name = "City")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter your Zip Code.")]
        [Display(Name = "Zip Code")]
        [StringLength(5, MinimumLength = 5)]
        public string ZipCode { get; set; }

        [Required(ErrorMessage = "Please enter your Phone Number.")]
        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [BindNever]
        public decimal OrderTotal { get; set; }
        [BindNever]
        public DateTime OrderPlaced { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }



    }
}
