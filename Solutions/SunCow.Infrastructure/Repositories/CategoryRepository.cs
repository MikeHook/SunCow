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
	public class CategoryRepository : NHibernateRepository<Category>, ICategoryRepository
	{
		public Category GetBy(string routeName)
		{
			IEnumerable<Category> category =
				Session.Query<Category>().Where(c => c.RouteName == routeName);
			if (category.Count() != 1)
			{
				return null;
			}
			return category.ElementAt(0);
		}
	}
}
