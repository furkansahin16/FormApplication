using FormApplication.DataAccess.Configurations.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Security.Claims;

namespace FormApplication.DataAccess.Contexts
{
    public class FormAppDb : IdentityDbContext
    {
        public const string ConnectionName = "FormApplication";
        private readonly IHttpContextAccessor? _contextAccessor;
        public FormAppDb(DbContextOptions<FormAppDb> options, IHttpContextAccessor contextAccessor) : base(options)
        {
            _contextAccessor = contextAccessor;
        }
        public FormAppDb(DbContextOptions<FormAppDb> options) : base(options) { }

        public virtual DbSet<AppUser> AppUsers { get; set; } = null!;
        public virtual DbSet<Form> Forms { get; set; } = null!;
        public virtual DbSet<Field> Fields { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(typeof(IEntityConfiguration).Assembly);
            base.OnModelCreating(builder);
        }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            SetBaseProperties();
            return base.SaveChangesAsync(cancellationToken);
        }
        private void SetBaseProperties()
        {
            var entries = ChangeTracker.Entries<BaseEntity>();

            var userId = _contextAccessor?.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier) ?? "User-NotFound";

            foreach (var entry in entries)
            {
                SetIfAdded(entry, userId);
            }
        }
        private void SetIfAdded(EntityEntry<BaseEntity> entry,string userId)
        {
            if(entry.State == EntityState.Added)
            {
                entry.Entity.Status = Status.Added;
                entry.Entity.CreatedAt = DateTime.Now;
                entry.Entity.CreatedBy = userId;
            }
        }
    }
}
