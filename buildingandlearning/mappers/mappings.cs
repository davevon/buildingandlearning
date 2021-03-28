using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using buildingandlearning.Data;
using buildingandlearning.Models;
using static buildingandlearning.Models.LeaveTypeViewModel;

namespace buildingandlearning.mapping
{
    public class mapper:Profile
    {

        public mapper()
        {
            CreateMap<LeaveType, LeaveTypeViewModel>().ReverseMap();
             CreateMap<LeaveType, CreateLeaveTypeViewModel>().ReverseMap();
             CreateMap<LeaveHistory, LeaveHistoryViewModel>().ReverseMap();
             CreateMap<LeaveAllocation, LeaveAllocationViewModel>().ReverseMap();
             CreateMap<Employee, EmployeeViewModel>().ReverseMap();
            
        }
    }
}
