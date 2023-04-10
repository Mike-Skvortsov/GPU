using Database.Migrations;
using Database.Repositories.Interfaces;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace Database.Repositories.Implements
{
	public class BaseRepository<T> : IBaseRepository<T> where T : class, IBaseEntity
	{
		protected readonly DBContext _dbContext;
		protected readonly DbSet<T> _dbSet;

		public BaseRepository(DBContext dbContext)
		{
			_dbContext = dbContext;
			_dbSet = _dbContext.Set<T>();
		}

		public async Task<IEnumerable<T>> GetAllAsync()
		{
			return await _dbSet.ToListAsync();
		}

		public async Task<T> GetByIdAsync(int id)
		{
			return await _dbSet.FindAsync(id);
		}

		public async Task<T> AddAsync(T entity)
		{
			await _dbSet.AddAsync(entity);
			await SaveChangesAsync();
			return entity;
		}

		public async Task<bool> DeleteByIdAsync(int id)
		{
			var entity = await GetByIdAsync(id);
			if (entity != null)
			{
				_dbSet.Remove(entity);
				await SaveChangesAsync();
				return true;
			}
			return false;
		}

		public async Task<T> UpdateAsync(T entity)
		{
			_dbSet.Update(entity);
			await SaveChangesAsync();
			return entity;

		}

		public async Task SaveChangesAsync()
		{
			await _dbContext.SaveChangesAsync();
		}
	}
}
