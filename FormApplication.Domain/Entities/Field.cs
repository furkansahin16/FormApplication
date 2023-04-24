namespace FormApplication.Domain.Entities
{
    public class Field : BaseEntity
    {
        public string Name { get; set; } = null!;
        public bool Required { get; set; } = true;
        public string Input { get; set; } = null!;
        public DataType DataType { get; set; }

        //Navigation
        public Guid FormId { get; set; }
        public virtual Form? Form { get; set; }
    }
}
