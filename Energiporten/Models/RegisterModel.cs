﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Energiporten.Models
{
    public class RegisterModel
    {
        [Required]
        public string Email { get; set; }

        public string Password { get; set; }

        public string PasswordAgain { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }




    }
}