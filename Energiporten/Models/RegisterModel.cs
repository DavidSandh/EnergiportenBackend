using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Energiporten.Models
{
    public class RegisterModel
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public string PasswordAgain { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public string Street_number { get; set; }

        public string Zip { get; set; }

        public string City { get; set; }

        public string Admin { get; set; }

        public string Country { get; set; }

        public string BuildingYear { get; set; }

        public string BuildingLiving { get; set; }

        public string BuildingFloor { get; set; }

        public string BuildingVentYear { get; set; }

        public string BuildingVentFloor { get; set; }

        public string BuildingTemp { get; set; }

        public string Buildings { get; set; }

        public string BuildingApartments { get; set; }

        public string BuildingTempIndoor { get; set; }

        public string BuildingFuse { get; set; }

        public string CarPool { get; set; }

        public string Alternativs { get; set; }

        public string BikePool { get; set; }


    }
}