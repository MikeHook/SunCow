using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using SunCow.Domain;
using System.Web.Mvc;


namespace SunCow.Web.Mvc.Controllers.ViewModels
{
	public class CategoriesModel
	{
		public CategoriesModel() 
		{
			CategoryLinks = new Dictionary<string, string>();			
		}

		public CategoriesModel(IList<Category> categories, UrlHelper urlHelper, string controllerName) : this()
		{
			foreach (var category in categories)
			{
				var categoryLink = urlHelper.Action("Category",controllerName, new {category = category.RouteName});
				CategoryLinks.Add(category.Name, categoryLink);
			}
		}

		public Dictionary<string, string> CategoryLinks { get; set; }
	}
}