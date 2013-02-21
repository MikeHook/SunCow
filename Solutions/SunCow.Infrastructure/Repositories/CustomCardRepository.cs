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
	public class CustomCardRepository : NHibernateRepository<CustomCard>, ICustomCardRepository
	{
		public IEnumerable<CustomCard> GetAllBy(Category category)
		{
			IEnumerable<CustomCard> cards =
				Session.Query<CustomCard>().Where(c => c.Category.Id == category.Id);
			return cards;
		}

		public CustomCard GetBy(string routeName)
		{
			IEnumerable<CustomCard> cards =
				Session.Query<CustomCard>().Where(c => c.RouteName == routeName);
			if (cards.Count() != 1)
			{
				return null;
			}
			return cards.ElementAt(0);     
		}

	}
}
