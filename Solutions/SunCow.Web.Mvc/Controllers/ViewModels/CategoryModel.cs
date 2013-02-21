using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using SunCow.Domain;
using System.Web.Mvc;


namespace SunCow.Web.Mvc.Controllers.ViewModels
{
	public class CategoryModel
	{
		public CategoryModel() 
		{
			Cards = new List<CardModel>();		
		}

		public CategoryModel(Category category, IEnumerable<Card> cards, string imageBasePath) : this()
		{
			CategoryName = category.Name;
			CategoryRouteName = category.RouteName;

			foreach (var card in cards)
			{
				Cards.Add(new CardModel(card, imageBasePath));				
			}
		}

		public string CategoryName { get; set; }
		public string CategoryRouteName { get; set; }
		public IList<CardModel> Cards { get; set; }

		public class CardModel
		{
			public CardModel() { }

			public CardModel(Card card, string imageBasePath) 
			{
				CardName = card.CardName;
				Price = card.Price;
				ThumbnailImagePath = card.GetImagePath(imageBasePath, card.ThumbnailImageName);
				Description = card.Description;
				CardRouteName = card.RouteName;
			}

			public string CardName { get; set; }
			public decimal Price { get; set; }
			public string ThumbnailImagePath { get; set; }
			public string Description { get; set; }
			public string CardRouteName { get; set; }			
		}
	}
}