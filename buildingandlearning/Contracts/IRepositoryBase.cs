using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace buildingandlearning.Contracts
{
    public interface IRepositoryBase<T> where T :class//base class the base class is passign in a class it could be any class
    {//base interface all other class can access this base class.
        ICollection<T> FindAll();
        T FindById(int id);//finding a record by id
        bool Create(T entity);//yes or no
        bool Update(T entity);
        bool Delete(T entity);
        bool save();

    }
}
