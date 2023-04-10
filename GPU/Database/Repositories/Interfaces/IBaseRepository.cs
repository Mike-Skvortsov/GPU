namespace Database.Repositories.Interfaces
{
	public interface IBaseRepository<T> where T : class
	{
		Task<IEnumerable<T>> GetAllAsync();
		Task<T> GetByIdAsync(int id);
		Task<T> AddAsync(T entity);
		Task<bool> DeleteByIdAsync(int id);
		Task<T> UpdateAsync(T entity);
		Task SaveChangesAsync();
	}
}
