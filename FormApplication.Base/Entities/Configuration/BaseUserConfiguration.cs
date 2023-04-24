using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BAExamApp.Core.Entities.EntityTypeConfigurations;

public abstract class BaseUserConfiguration<T> : BaseEntityConfiguration<T> where T : BaseUser
{
    public override void Configure(EntityTypeBuilder<T> builder)
    {
        base.Configure(builder);
        builder.Property(x => x.UserName).IsRequired();
    }
}
