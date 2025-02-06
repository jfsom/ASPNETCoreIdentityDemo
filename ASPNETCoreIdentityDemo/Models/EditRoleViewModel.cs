﻿using System.ComponentModel.DataAnnotations;

namespace ASPNETCoreIdentityDemo.Models
{
    public class EditRoleViewModel
    {
        [Required]
        public string Id { get; set; }
        [Required(ErrorMessage = "Role Name is Required")]
        public string RoleName { get; set; }
    }
}
