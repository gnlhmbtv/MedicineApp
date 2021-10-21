using Entities.Interfaces;


namespace Entities.Models
{
    public class Drug : IEntity
    {
        public int Id { get ; set ; }
        public string DrugName { get; set; }
        public int Price { get; set; }
    }
}
