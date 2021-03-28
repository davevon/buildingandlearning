using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace buildingandlearning.Models
{
    public class LeaveAllocationViewModel
    {
  
        public int id { get; set; }
        [Required]
        public int NumberOfDays { get; set; }
        public DateTime DAteCreated { get; set; }
       
        public EmployeeViewModel employee { get; set; }
        public string Employeeid { get; set; }
    
        public LeaveTypeViewModel LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public IEnumerable<SelectListItem> Employees { get; set; }//dropdown selection
        public IEnumerable<SelectListItem> Leavetypes { get; set; }//dropdown selection

    }
}
