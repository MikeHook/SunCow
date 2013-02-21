using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using SunCow.Domain;
using System.Web.Mvc;


namespace SunCow.Web.Mvc.Controllers.ViewModels
{
	public class CustomCardModel
	{
		public CustomCardModel()
		{

		}

		public CustomCardModel(CustomCard card, string imageBasePath)
			: this()
		{
			CardName = card.Card.CardName;
			Price = card.Card.Price;
			OutsideImagePath = card.Card.GetImagePath(imageBasePath, card.Card.OutsideImageName);
			InsideImagePath = card.GetInsideImagePath(imageBasePath);
			Description = card.Card.Description;
			CardRouteName = card.RouteName;
		}

		public string CardName { get; set; }
		public decimal Price { get; set; }
		public string OutsideImagePath { get; set; }
		public string InsideImagePath { get; set; }
		public string Description { get; set; }
		public string CardRouteName { get; set; }	
	}
}