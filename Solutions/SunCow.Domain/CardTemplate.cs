namespace SunCow.Domain
{
    using SharpArch.Domain.DomainModel;

    public class CardTemplate : Entity
    {
        public virtual string CardName { get; set; }
    }
}