namespace SunCow.Domain
{
    using SharpArch.Domain.DomainModel;
    using System.Collections.Generic;
    using System.IO;

    public class Card : Entity
    {
        //Default constructor needed for NHibernate
        public Card() { }

		public Card(Category category)
        {
            Category = category;  
        }

        public virtual Category Category { get; set; }
        public virtual string CardName { get; set; }
		public virtual decimal Price { get; set; }
		public virtual string Description { get; set; }
        public virtual string ThumbnailImageName { get; set; }
        public virtual string OutsideImageName { get; set; }
        public virtual string InsideImageName { get; set; }
        public virtual bool HasOutsideMessage { get; set; }

		/// <summary>
		/// The route name used in the website URL segments
		/// </summary>
		//TODO - Add a unique constraint to this property & ensure only allowed characters are used in the name	
		public virtual string RouteName { get; set; }

		//TODO - move to a task
        public virtual string GetImagePath(string imageBasePath, string imageName)
        {
			if (imageBasePath.EndsWith("/") == false)
				imageBasePath = string.Format("{0}/", imageBasePath);

            string templatesDirectory = "Cards/";

			var categoryDirectory = Category.ImageDirectory;
			if (categoryDirectory.EndsWith("/") == false)
				categoryDirectory = string.Format("{0}/", categoryDirectory);

			return string.Format("{0}{1}{2}{3}", imageBasePath, templatesDirectory, categoryDirectory, imageName);
        }        

        //Implement this if relationship is required
        //public virtual IList<Card> Cards { get; set; }
    }
}