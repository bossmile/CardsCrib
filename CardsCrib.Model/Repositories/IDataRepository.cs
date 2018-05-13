using System;
using System.Collections.Generic;
using System.Text;

namespace CardsCrib.Core.Repositories
{
	public interface IDataRepository<TEntity, U> where TEntity : class
	{
		ICollection<TEntity> GetAll();
		//TEntity Get(U id);
		//long Add(TEntity b);
		//long Update(U id, TEntity b);
		//long Delete(U id);
	}
}
