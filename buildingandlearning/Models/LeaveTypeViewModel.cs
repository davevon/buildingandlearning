﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace buildingandlearning.Models
{
    public class LeaveTypeViewModel
    {

        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }


        public class CreateLeaveTypeViewModel
         {    public string Name { set; get; }

              }


    }
}
