
namespace FormApplication.Domain.Entities
{
    public class User : BaseUser
    {
        //Navigation
        public virtual ICollection<Form> Forms { get; set; }
        public User()
        {
            Forms = new HashSet<Form>();
        }
    }
}
