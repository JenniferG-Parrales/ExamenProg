using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Interfaces
{
    public interface IBaseService<T>
    {
        void Create(T e);
        void Delete(T e);
        void Update(int index, T a);
        List<T> GetAll();
        List<T> GetAllBy(Predicate<T> predicate);
        T GetAnyBy(Predicate<T> predicate);
    }
}
