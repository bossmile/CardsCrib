using System;
using System.Collections.Generic;
using System.Text;
using CardsCrib.Core.Repositories;

namespace CardsCrib.Core
{
    public interface IUnitOfWork<U>
    {
		void SaveChanges();
		void LazyLoadingEnabled(bool enabled);
		IDataRepository<TEntity, U> Repository<TEntity>() where TEntity : class;

		ICardRepository CardRepository { get; }
	}
}
