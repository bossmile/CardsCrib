using CardsCrib.Core;
using CardsCrib.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardsCrib.DAL.Repositories
{
    public interface ICardRepository : IDataRepository<Card, int>
    {
		IEnumerable<Card> GetCardList();
	}
}
