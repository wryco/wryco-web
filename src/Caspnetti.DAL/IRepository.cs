namespace Caspnetti.DAL;

public interface IRepository<T> where T : class
{
    IEnumerable<T> GetAll();
    T GetById(int id);
    IEnumerable<T> Find(T entity);
    void Insert(T entity);
    void Delete(int id);
    void Delete(T entity);
    void Update(T entity);
    void Save();
}
