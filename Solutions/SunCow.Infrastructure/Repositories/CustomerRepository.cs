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
	public class CustomerRepository : NHibernateRepository<Customer>, ICustomerRepository
	{
		public Customer GetSampleCustomer()
		{
			return Session.Query<Customer>().First();    
		}

	}
}
