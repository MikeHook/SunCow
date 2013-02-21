using System;
using SharpArch.Domain.PersistenceSupport;
namespace SunCow.Domain.Contracts.Repositories
{
	public interface ICustomerRepository : IRepository<Customer>
	{
		SunCow.Domain.Customer GetSampleCustomer();
	}
}
