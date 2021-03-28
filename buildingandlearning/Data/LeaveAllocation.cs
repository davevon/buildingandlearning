using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace buildingandlearning.Data
{
    public class LeaveAllocation
    {

        [Key]
        public  int id { get; set; }
    public  int NumberOfDays { get; set; }
    public  DateTime DAteCreated { get; set; }
        [ForeignKey ("Empoyeeid")]
    public  Employee employee { get; set; }
        public  string Employeeid { get; set; }
        [ForeignKey("LeaveTypeId")]
        public  LeaveType LeaveType { get; set; }
    public  int LeaveTypeId { get; set; }
    }
}
