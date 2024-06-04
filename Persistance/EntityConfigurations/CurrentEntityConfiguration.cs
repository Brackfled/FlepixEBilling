using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.EntityConfigurations
{
    public class CurrentEntityConfiguration : IEntityTypeConfiguration<Current>
    {
        public void Configure(EntityTypeBuilder<Current> builder)
        {
            builder.ToTable("Currents").HasKey(c => c.Id);

            builder.Property(c => c.Id).HasColumnName("Id").IsRequired();
            builder.Property(c => c.TaxDepartmentId).HasColumnName("TaxDepartmentId").IsRequired();
            builder.Property(c => c.CurrentCode).HasColumnName("CurrentCode").IsRequired();
            builder.Property(c => c.CurrentName).HasColumnName("CurrentName").IsRequired();
            builder.Property(c => c.CardType).HasColumnName("CardType").IsRequired();
            builder.Property(c => c.CurrentType).HasColumnName("CurrentType").IsRequired();
            builder.Property(c => c.Status).HasColumnName("Status").IsRequired();
            builder.Property(c => c.CurrentFirstName).HasColumnName("CurrentFirstName");
            builder.Property(c => c.CurrentLastName).HasColumnName("CurrentLastName");
            builder.Property(c => c.TaxNumberOrIdentityNumber).HasColumnName("TaxNumberOrIdentityNumber").IsRequired();
            builder.Property(c => c.Email).HasColumnName("Email").IsRequired();
            builder.Property(c => c.AddressHeader).HasColumnName("AddressHeader").IsRequired();
            builder.Property(c => c.AddressMainStreet).HasColumnName("AddressMainStreet");
            builder.Property(c => c.AddressNeighbourhood).HasColumnName("AddressNeighbourhood").IsRequired();
            builder.Property(c => c.AddressStreet).HasColumnName("AddressStreet");
            builder.Property(c => c.AddressBABNo).HasColumnName("AddressBABNo").IsRequired();
            builder.Property(c => c.AddressDistrict).HasColumnName("AddressDistrict").IsRequired();
            builder.Property(c => c.AddressCity).HasColumnName("AddressCity").IsRequired();
            builder.Property(c => c.AddressPostCode).HasColumnName("AddressPostCode").IsRequired();
            builder.Property(c => c.AddressNote).HasColumnName("AddressNote");
            builder.Property(c => c.PhoneNumber).HasColumnName("PhoneNumber").IsRequired();
            builder.Property(c => c.FaxNumber).HasColumnName("FaxNumber");
            builder.Property(c => c.CreatedDate).HasColumnName("CreatedDate").IsRequired();
            builder.Property(c => c.UpdatedDate).HasColumnName("UpdatedDate");
            builder.Property(c => c.DeletedDate).HasColumnName("DeletedDate");


            builder.HasIndex(indexExpression: c => c.CurrentName, name: "UK_Currents_CurrentName");
            builder.HasOne(c => c.TaxDepartment);

            builder.HasBaseType((string)null!);

        }
    }
}
