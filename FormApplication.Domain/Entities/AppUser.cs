namespace FormApplication.Domain.Entities
{
    public class AppUser : BaseUser
    {
        //Navigation
        public virtual ICollection<Form> Forms { get; set; }
        public AppUser()
        {
            Forms = new HashSet<Form>();
        }
    }
}
