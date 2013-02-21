using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpArch.NHibernate;
using SharpArch.NHibernate.Contracts.Repositories;
using SunCow.Domain;
using NHibernate.Linq;
using SunCow.Domain.Contracts.Repositories;

namespace SunCow.Infrastructure.Repositories
{
	public class CardRepository : NHibernateRepository<Card>, ICardRepository
	{
		public IEnumerable<Card> GetAllBy(Category category)
		{
			IEnumerable<Card> cards =
				Session.Query<Card>().Where(c => c.Category.Id == category.Id);
			return cards;
		}

		public Card GetBy(string routeName)
		{
			IEnumerable<Card> cards =
				Session.Query<Card>().Where(c => c.RouteName == routeName);
			if (cards.Count() != 1)
			{
				return null;
			}
			return cards.ElementAt(0);     
		}

	}
}
