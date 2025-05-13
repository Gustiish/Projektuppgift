namespace Projektuppgift.Data
{
    public interface IGenericRepository<T> where T : class
    {
        //List
        IEnumerable<T> GetAll();
        //FindByID
        T GetByID(int id);
        //Create
        void Add(T entity);
        //Update    
        void Update(T entity);
        //Delete
        bool Delete(T entity);



    }
}
