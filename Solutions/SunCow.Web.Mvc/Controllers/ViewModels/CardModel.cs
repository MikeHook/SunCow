using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using SunCow.Domain;
using System.Web.Mvc;


namespace SunCow.Web.Mvc.Controllers.ViewModels
{
	public class CardModel
	{
		public CardModel()
		{

		}

		public CardModel(Card card, string imageBasePath)
			: this()
		{
			CardName = card.CardName;
			Price = card.Price;
			OutsideImagePath = card.GetImagePath(imageBasePath, card.OutsideImageName);
			InsideImagePath = card.GetImagePath(imageBasePath, card.InsideImageName);
			Description = card.Description;
			HasOutsideMessage = card.HasOutsideMessage;
			CardRouteName = card.RouteName;
		}

		public string CardName { get; set; }
		public decimal Price { get; set; }
		public string OutsideImagePath { get; set; }
		public string InsideImagePath { get; set; }
		public string Description { get; set; }
		public string CardRouteName { get; set; }
		public bool HasOutsideMessage { get; set; }
	}
}