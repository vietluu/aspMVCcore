using Microsoft.EntityFrameworkCore;
using MVC03.Data;
using MVC03.DAL;
namespace MVC03.DAL
{
public class MemberRepository<T> : IMemberRepository<T> where T : class
{
    private readonly MvcContext _context;
    private readonly DbSet<T> _dbSet;

    public MemberRepository(MvcContext context)
    {
        _context = context;
        _dbSet = context.Set<T>();
    }

    public IEnumerable<T> GetAll()
    {
        return _dbSet.ToList();
    }

   public T GetById(int id)
    {
        return _dbSet.Find(id);
    }

    public void Insert(T entity)
    {
        _dbSet.Add(entity);
    }

    public void Update(T entity)
    {
        _context.Entry(entity).State = EntityState.Modified;
    }

    public void Delete(T entity)
    {
        _dbSet.Remove(entity);
    }
}
     
}