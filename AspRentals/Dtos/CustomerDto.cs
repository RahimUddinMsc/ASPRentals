using AspRentals.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AspRentals.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public String Name { get; set; }

        public MembershipTypeDto MembershipType { get; set; }

        //[Min18YearsAsAMember]
        public DateTime? DateOfBirth { get; set; }

        public Boolean IsSuscribeToNewsLetter { get; set; }
   
        public byte MembershipTypeId { get; set; }

    }
}