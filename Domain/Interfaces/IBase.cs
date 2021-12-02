using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IBase<T>
    {
        void Create(T e);
        void Delete(T e);
        void Update(int index, T a);
        List<T> GetAll();
        List<T> GetAllBy(Predicate<T> predicate);
        T GetAnyBy(Predicate<T> predicate);
    }
}
