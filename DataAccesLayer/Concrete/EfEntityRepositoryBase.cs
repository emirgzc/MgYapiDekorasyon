using DataAccesLayer.Abstract;
using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Concrete
{
	public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
		where TEntity : class, IEntity, new()
		where TContext : DbContext, new()
	{
		public void Add(TEntity entity)
		{
			using (TContext context = new TContext())
			{
				var addedentity = context.Entry(entity);
				addedentity.State = EntityState.Added;
				context.SaveChanges();
			}
		}

		public void Delete(TEntity entity)
		{
			using (TContext context = new TContext())
			{
				var deleteentity = context.Entry(entity);
				deleteentity.State = EntityState.Deleted;
				context.SaveChanges();
			}
		}

		public TEntity Get(Expression<Func<TEntity, bool>> filter)
		{
			using (TContext context = new TContext())
			{
				return context.Set<TEntity>().SingleOrDefault(filter);
			}
		}

		public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
		{
			using (TContext context = new TContext())
			{
				return filter == null ?
					context.Set<TEntity>().ToList() :
					context.Set<TEntity>().Where(filter).ToList();
			}
		}

		public void Update(TEntity entity)
		{
			using (TContext context = new TContext())
			{
				var updateentity = context.Entry(entity);
				updateentity.State = EntityState.Modified;
				context.SaveChanges();
			}
		}
	}
}
