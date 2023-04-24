using BAExamApp.Core.Entities.EntityTypeConfigurations;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FormApplication.DataAccess.Configurations
{
    public class FieldConfiguration : BaseEntityConfiguration<Field>
    {
        public override void Configure(EntityTypeBuilder<Field> builder)
        {
            base.Configure(builder);
        }
    }
}
