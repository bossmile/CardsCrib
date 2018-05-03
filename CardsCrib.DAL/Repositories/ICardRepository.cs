using CardsCrib.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardsCrib.DAL.Repositories
{
    public interface ICardRepository
    {
		IEnumerable<Card> GetCardList();
	}
}
