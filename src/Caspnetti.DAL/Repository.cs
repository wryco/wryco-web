using Caspnetti.DAL;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Caspnetti.DAL;

public class Repository<T> : IRepository<T> where T : class
{
    private readonly ApplicationDbContext _context;
    private readonly DbSet<T> _dbSet;

    public Repository(ApplicationDbContext context)
    {
        _context = context;
        _dbSet = _context.Set<T>();
    }

    // Sync

    // Read
    public IEnumerable<T> FindAll() => _dbSet.ToList();
    public IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate)
    {
        return _dbSet.Where(predicate).ToList();
    }
    public T FindOneBy(Expression<Func<T, bool>> predicate)
    {
        return _dbSet.Where(predicate).FirstOrDefault();
    }
    public T FindById(int id) => _dbSet.Find(id);
    // Write
    public void Add(T entity) => _dbSet.Add(entity);
    public void Update(T entity) => _dbSet.Update(entity);
    // Delete
    public void Delete(int id)
    {
        T entity = FindById(id);
        if (entity != null)
        {
            _dbSet.Remove(entity);
        }
    }
    public void Delete(T entity)
    {
        _dbSet.Remove(entity);
    }
    // Execute
    public void Save()
    {
        _context.SaveChanges();
    }

    // Async

    // Read
    public async Task<IEnumerable<T>> FindAllAsync() => await _dbSet.ToListAsync();
    public async Task<IEnumerable<T>> FindByAsync(Expression<Func<T, bool>> predicate)
    {
        return await _dbSet.Where(predicate).ToListAsync();
    }
    public async Task<T> FindOneByAsync(Expression<Func<T, bool>> predicate)
    {
        return await _dbSet.Where(predicate).FirstOrDefaultAsync();
    }
    public async Task<T> FindByIdAsync(int id)
    {
        return await this._dbSet.FindAsync(id);
    }
    // Write
    public async Task AddAsync(T entity)
    {
        await _dbSet.AddAsync(entity);
    }
    // void Update(T entity);
    // Delete
    // void Delete(int id);
    // void Delete(T entity);
    // Execute
    public async Task SaveAsync()
    {
        await _context.SaveChangesAsync();
    }
}

    // public IEnumerable<T> FindBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
    // {
    //     IEnumerable<T> query = _dbset.Where(predicate).AsEnumerable(); 
    //     return query;
    // }
