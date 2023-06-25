using Microsoft.EntityFrameworkCore;
using MVC03.Data;

namespace MVC03.DAL
{
    public interface IMemberRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}