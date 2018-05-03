using CardsCrib.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardsCrib.DAL.Repositories
{
    class CardRepository : ICardRepository
    {
		private CardsCribContext _DbContext;

		public CardRepository(CardsCribContext DbContext)
		{
			_DbContext = DbContext;
		}

		public IEnumerable<Card> GetCardList()
		{
			return _DbContext.Card;
		}
    }
}
