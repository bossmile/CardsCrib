using CardsCrib.Core;
using CardsCrib.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardsCrib.DAL.Repositories
{
    public class Repository<TEntity> : IDataRepository<TEntity, int> where TEntity : class
    {
		protected readonly ICardsCribDBContext _context;
		private readonly DbSet<TEntity> _entitySet;

		public Repository (ICardsCribDBContext dbContext)
		{
			_context = dbContext;
			_entitySet = _context.ModelSet<TEntity>();
		}

		public virtual ICollection<TEntity> GetAll()
		{
			return _entitySet.AsNoTracking().ToList();
		}
    }
}
