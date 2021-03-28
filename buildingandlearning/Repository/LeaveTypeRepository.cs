using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using buildingandlearning.Contracts;
using buildingandlearning.Data;

namespace buildingandlearning.Repository
{
    public class LeaveTypeRepository : ILeaveTypeRepository//the leave type repository inherits from ileavetyperepository two red line will be show and they are for 1.toget access to the class 2 for the interface body fuctions
    {// letting the repsoitory classes know about the database.

        private readonly ApplicationDbContext _Db;

        public LeaveTypeRepository(ApplicationDbContext db)
        {
            _Db = db;
                   
        }

        public bool Create(LeaveType entity)
        {
            _Db.LeaveTypes.Add(entity);
            return save();
            // throw new NotImplementedException();
        }

        public bool Delete(LeaveType entity)
        {
            _Db.LeaveTypes.Remove(entity);
            return save();
            //throw new NotImplementedException();
        }

        public ICollection<LeaveType> FindAll()
        {
            //throw new NotImplementedException();
            _Db.LeaveTypes.ToList();
            return _Db.LeaveTypes.ToList();// getting all leave type from the database
        }

        public LeaveType FindById(int id)
        {
            _Db.LeaveTypes.Find(id);
            //throw new NotImplementedException();
            return _Db.LeaveTypes.Find(id);
        }

        public ICollection<LeaveType> GetEmployeeByLeaveType(int id)
        {
            throw new NotImplementedException();
        }

        public bool save()
        {
            var Changed = _Db.SaveChanges();
            return Changed>0;
            //throw new NotImplementedException();
        }

        public bool Update(LeaveType entity)
        {
            _Db.LeaveTypes.Update(entity);
            return save();
            //throw new NotImplementedException();
        }
    }
}
