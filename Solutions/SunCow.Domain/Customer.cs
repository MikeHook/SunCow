﻿namespace SunCow.Domain
{
    using SharpArch.Domain.DomainModel;
    using System.Collections.Generic;

    public class Customer : Entity
    {
        public Customer()
        {
            Cards = new List<Card>();
        }

        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }

        /// <summary>
        /// The sub directory that images for this customer will be stored in
        /// </summary>
        //TODO - Add a unique constraint to this property
        public virtual string ImageDirectory { get; set; }

        public virtual IList<Card> Cards { get; set; }
    }
}