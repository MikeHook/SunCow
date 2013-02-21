namespace SunCow.Web.Mvc.Controllers
{
    using System.Web.Mvc;
	using SunCow.Domain.Contracts.Repositories;
	using SunCow.Web.Mvc.Controllers.ViewModels;
	using System.Configuration;

    public abstract class BaseController : Controller
    {
		public string ImageBasePath
		{
			get { return ConfigurationManager.AppSettings["ImageBasePath"]; }
		}
	}
}
