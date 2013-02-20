namespace SunCow.Domain
{
    using SharpArch.Domain.DomainModel;
    using System.Collections.Generic;

    public class Category : Entity
    {
        public Category()
        {
            Cards = new List<Card>();
        }

        public virtual string Name { get; set; }

		/// <summary>
		/// The route name used in the website URL segments
		/// </summary>
		//TODO - Add a unique constraint to this property & ensure only allowed characters are used in the name	
		public virtual string RouteName { get; set; }

        /// <summary>
        /// The sub directory that template images in this category  will be stored in 
        /// </summary>
        //TODO - Add a unique constraint to this property
        public virtual string ImageDirectory { get; set; }

        public virtual IList<Card> Cards { get; set; }
    }
}