﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PetStore.Models;
using System.ComponentModel.DataAnnotations;

namespace PetStore.Models
{
    public class RegisterViewModel
    {
        [Required]
        public string Password { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        public string  FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

    }
}
