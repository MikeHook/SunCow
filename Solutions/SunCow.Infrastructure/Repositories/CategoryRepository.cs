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

	}
}
