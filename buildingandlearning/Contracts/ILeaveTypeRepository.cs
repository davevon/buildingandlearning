using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using buildingandlearning.Data;

namespace buildingandlearning.Contracts
{
    public interface ILeaveTypeRepository:IRepositoryBase<LeaveType> //this class implements the base class. which passes in a specific class of <leave type>

    {
        ICollection<LeaveType> GetEmployeeByLeaveType(int id);
    }
}
