using Day6_efcore1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Day6_efcore1.Repositories.Configurations
{
    //Bu konfigurasyonu yapmasak dahi Models klasörü altında kurduğumuz ilişkiler sayesinde veri tabanına doğru bir şekilde yansılıtacaktır. Aşağıdaki bilgi ekstra öğrenimdir.
    public class PlayerConfiguration : IEntityTypeConfiguration<Player> //Player tablosu için konfigurasyon yapıyoruz.
    {
        public void Configure(EntityTypeBuilder<Player> builder)
        {
            builder.ToTable("Players_db").HasKey(p => p.Id);
            builder.Property(p => p.Id).HasColumnName("player_id");
            builder.Property(p => p.Name).HasColumnName("player_name");
            builder.Property(p => p.OutfitId).HasColumnName("outfit_id");
            builder.Property(p => p.Age).HasColumnName("player_age");
            builder.Property(p => p.BranchId).HasColumnName("branch_id");
            builder.Property(p => p.TeamId).HasColumnName("team_id");
            builder.Property(p => p.Price).HasColumnName("player_price");

            builder.HasOne(p => p.Team); //player'ın 1 takımı (Takım ile 1'e çok ilişki var)
            builder.HasOne(p => p.Outfit); //player'ın 1 forması (Outfit ile 1'e 1 ilişki var)
            builder.HasOne(p => p.Branch); //player'ın 1 branşı (Branş ile 1'e çok ilişki var)

            //seeding data
            builder.HasData(
                new Player()
                {
                    Id = 1,
                    Age = 30,
                    BranchId = 1,
                    Name = "Mauro Icardi",
                    OutfitId = 1,
                    Price = 300000000,
                    TeamId = 1
                });

        }
    }
}
