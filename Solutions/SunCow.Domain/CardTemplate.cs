namespace SunCow.Domain
{
    using SharpArch.Domain.DomainModel;
    using System.Collections.Generic;

    public class CardTemplate : Entity
    {
        public virtual string CardName { get; set; }
        public virtual string ImagePath { get; set; }

        //Implement this if relationship is required
        //public virtual IList<Card> Cards { get; set; }
    }
}