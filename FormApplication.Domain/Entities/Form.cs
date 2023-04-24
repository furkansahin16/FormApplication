
namespace FormApplication.Domain.Entities
{
    public class Form : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }

        //Navigation
        public Guid UserId { get; set; }
        public virtual User? User { get; set; }
        public virtual ICollection<Field> Fields { get; set; }
        public Form()
        {
            Fields= new HashSet<Field>();
        }
    }
}
