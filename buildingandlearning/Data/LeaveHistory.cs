using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace buildingandlearning.Data
{
    public class LeaveHistory
    {
        [Key]

        public int id { get; set; }
        [ForeignKey("RequestingEmployeeId")]
     public Employee RequestingEmployee { get; set; }
     public string RequestingEmployeeId { get; set; }
     public DateTime startDate { get; set; }
     public DateTime endDate { get; set; }
        [ForeignKey("LeaveTypeId")]
     public LeaveType LeaveType { get; set; }
        public int LeaveTypeId { get; set; }

     public DateTime DateRequested { get; set; }
     public DateTime Actioned { get; set; }//approved or not
     public bool? Approved{get; set; }
        [ForeignKey("ApprovedById")]
            public Employee ApprovedBy { get; set; }
     public string ApprovedById { get; set; }

    }
}
