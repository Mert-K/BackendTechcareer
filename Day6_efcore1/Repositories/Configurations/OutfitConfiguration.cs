﻿using Day6_efcore1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Day6_efcore1.Repositories.Configurations
{
    public class OutfitConfiguration : IEntityTypeConfiguration<Outfit>
    {
        public void Configure(EntityTypeBuilder<Outfit> builder)
        {
            builder.ToTable("Outfits_db").HasKey(o => o.Id);
            builder.Property(o => o.Id).HasColumnName("outfit_id");
            builder.Property(o => o.BrandName).HasColumnName("outfit_brand_name");
            builder.Property(o => o.Type).HasColumnName("outfit_type");
            builder.Property(o => o.No).HasColumnName("outfit_no");


            builder.HasOne(o => o.Player).WithOne(p => p.Outfit).HasForeignKey<Player>(p => p.OutfitId); //1'e 1 ilişki'de Foreign Key kolonu bu şekilde gösteriliyor.


            //Seeding data
            builder.HasData(
                new Outfit() { Id = 1, BrandName = "Adidas", No = 42, Type = OutfitType.Winter }
                );

        }
    }
}
