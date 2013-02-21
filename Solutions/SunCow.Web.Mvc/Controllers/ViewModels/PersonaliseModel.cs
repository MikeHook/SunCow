using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using SunCow.Domain;
using System.Web.Mvc;


namespace SunCow.Web.Mvc.Controllers.ViewModels
{
	public class PersonaliseModel
	{
		public PersonaliseModel()
		{

		}

		public string Salutation { get; set; }
		public string OutsideMessage { get; set; }
		public string InsideMessage { get; set; }
		public string SignOff { get; set; }

		public string CardRouteName { get; set; }
	}
}