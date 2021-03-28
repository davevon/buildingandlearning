using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace buildingandlearning.Models
{
    public class LeaveHistoryViewModel
    {
        public int id { get; set; }
       
        public EmployeeViewModel RequestingEmployee { get; set; }
        public string RequestingEmployeeId { get; set; }
        [Required]
        public DateTime startDate { get; set; }
        [Required]
        public DateTime endDate { get; set; }
      
        public LeaveTypeViewModel LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public IEnumerable<SelectListItem> Leavetypes { get; set; }//dropdown selection
       
        public DateTime DateRequested { get; set; }
        public DateTime Actioned { get; set; }//approved or not
        public bool? Approved { get; set; }
      
        public EmployeeViewModel ApprovedBy { get; set; }
        public string ApprovedById { get; set; }
    }
}
