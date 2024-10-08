using ItMarathon.Dal.Entities;
using ItMarathon.Dal.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Diagnostics.CodeAnalysis;

namespace ItMarathon.Dal.Configuration;

[ExcludeFromCodeCoverage]
public class PropertyDefinitionConfiguration : IEntityTypeConfiguration<PropertyDefinition>
{
    public void Configure(EntityTypeBuilder<PropertyDefinition> builder)
    {
        builder.HasIndex(pd => pd.Name).IsUnique();

        builder.HasData(    
            new PropertyDefinition() { Id = 1, Name = "Вид тварини", IsMandatory = true },
            new PropertyDefinition() { Id = 2, Name = "Різновид", IsMandatory = true },
            new PropertyDefinition() { Id = 3, Name = "Стать", IsMandatory = true },
            new PropertyDefinition() { Id = 5, Name = "Забарвлення" , IsMandatory = false },
            new PropertyDefinition() { Id = 6, Name = "Стерилізація", IsMandatory = false, PropertyDefinitionType = PropertyDefinitionType.Custom, Category = "Health" },
            new PropertyDefinition() { Id = 7, Name = "Вакцинація", IsMandatory = false, PropertyDefinitionType = PropertyDefinitionType.Custom, Category = "Health" },
            new PropertyDefinition() { Id = 8, Name = "Чіп", IsMandatory = false, PropertyDefinitionType = PropertyDefinitionType.Custom, Category = "Health" },
            new PropertyDefinition() { Id = 9, Name = "Обробка від паразитів", IsMandatory = false, PropertyDefinitionType = PropertyDefinitionType.Custom, Category = "Health" },
            new PropertyDefinition() { Id = 10, Name = "Ветпаспорт", IsMandatory = false, PropertyDefinitionType = PropertyDefinitionType.Custom, Category = "Documents" },
            new PropertyDefinition() { Id = 11, Name = "Родовід", IsMandatory = false, PropertyDefinitionType = PropertyDefinitionType.Custom, Category = "Documents" },
            new PropertyDefinition() { Id = 12, Name = "FCI/KCY", IsMandatory = false, PropertyDefinitionType = PropertyDefinitionType.Custom, Category = "Documents" },
            new PropertyDefinition() { Id = 13, Name = "Щеняча метрика", IsMandatory = false, PropertyDefinitionType = PropertyDefinitionType.Custom, Category = "Documents" }
        );
    }
}
