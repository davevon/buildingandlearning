using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace buildingandlearning.Data
{
    public class Employee
    {



        ///add fields
        public string Firstname { get; set; }
        public string Lasttname { get; set; }
        public string TaxId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateJoined { get; set; }
     

    }
}
