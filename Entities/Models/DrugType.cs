using Entities.Interfaces;


namespace Entities.Models
{
    public class DrugType : IEntity
    {
        public int Id { get ; set ; }
        public string TypeName { get; set; }
        public int DrugCount { get; set; }
    }
}
