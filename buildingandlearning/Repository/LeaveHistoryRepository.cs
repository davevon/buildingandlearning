using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using buildingandlearning.Contracts;
using buildingandlearning.Data;
//using buildingandlearning.Leave_Allocation_repository;


namespace buildingandlearning.Repository
{
    public class LeaveHistoryRepository : ILeaveHistoryRepository
    {
        private readonly ApplicationDbContext _db;

        public LeaveHistoryRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public bool Create(LeaveHistory entity)
        {
            _db.LeaveHistories.Add(entity);
            return save();
            // throw new NotImplementedException();
        }

        public bool Delete(LeaveHistory entity)
        {
            _db.LeaveHistories.Remove(entity);
            return save();
            //throw new NotImplementedException();
        }

        public ICollection<LeaveHistory> FindAll()
        {
            _db.LeaveHistories.ToList();
            return _db.LeaveHistories.ToList();
            //throw new NotImplementedException();
        }

        public LeaveHistory FindById(int id)
        {
            _db.LeaveHistories.Find(id);
            return _db.LeaveHistories.Find(id);
            //throw new NotImplementedException();
        }

        public bool save()
        {
            _db.SaveChanges();
            return _db.SaveChanges() > 0;
            //throw new NotImplementedException();
        }

        public bool Update(LeaveHistory entity)
        {
            _db.LeaveHistories.Update(entity);
            return save();
            //throw new NotImplementedException();
        }
    }
}
