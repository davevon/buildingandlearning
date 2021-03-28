using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using buildingandlearning.Contracts;
using buildingandlearning.Data;

namespace buildingandlearning.Repository
{
    public class LeaveallocationRepository : ILeaveAllocationHistoryRepository
    {
        private readonly ApplicationDbContext _db;
        public LeaveallocationRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool Create(LeaveAllocation entity)
        {
            _db.LeaveAllocations.Add(entity);
            return save();
            //throw new NotImplementedException();
        }

        public bool Delete(LeaveAllocation entity)
        {
            _db.LeaveAllocations.Remove(entity);
            return save();
            // throw new NotImplementedException();
        }

        public ICollection<LeaveAllocation> FindAll()
        {
            _db.LeaveAllocations.ToList();
            return _db.LeaveAllocations.ToList();
            //throw new NotImplementedException();
        }

        public LeaveAllocation FindById(int id)
        {
            _db.LeaveAllocations.Find(id);
            return _db.LeaveAllocations.Find(id);
           // throw new NotImplementedException();
        }

        public bool save()
        {
            _db.SaveChanges();
            return _db.SaveChanges () > 0;
            //throw new NotImplementedException();
        }

        public bool Update(LeaveAllocation entity)
        {
            _db.LeaveAllocations.Update(entity);
            return save();
           // throw new NotImplementedException();
        }
    }
}