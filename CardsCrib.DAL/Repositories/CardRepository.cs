using CardsCrib.Core;
using CardsCrib.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardsCrib.DAL.Repositories
{
    public class CardRepository : Repository<Card>, ICardRepository
    {
		//private CardsCribContext _DbContext;

		public CardRepository(ICardsCribDBContext DbContext) : base(DbContext)
		{
			//_DbContext = DbContext;
		}

		//public IEnumerable<Card> GetAll()
		//{
		//	return null;// _DbContext.Card;
		//}
    }
}
