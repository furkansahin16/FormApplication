using BAExamApp.Core.Entities.EntityTypeConfigurations;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FormApplication.DataAccess.Configurations
{
    public class FormConfiguration : BaseEntityConfiguration<Form>
    {
        public override void Configure(EntityTypeBuilder<Form> builder)
        {
            base.Configure(builder);

            builder.HasOne(x => x.User).WithMany(x => x.Forms).HasForeignKey(x => x.UserId);
            builder.HasMany(x => x.Fields).WithOne(x => x.Form).HasForeignKey(x => x.FormId);
        }
    }
}
