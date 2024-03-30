using Microsoft.EntityFrameworkCore;
using NotZara.Domain.Models;

namespace NotZara.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Item> Items { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<BasketItems> BasketItems { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Item>(cof =>
            {
                cof.ToTable("Item");
            });
            
            modelBuilder.Entity<Basket>(cof =>
            {
                cof.ToTable("Basket");
                cof.HasKey(x => x.Id);
            });

            modelBuilder.Entity<BasketItems>(cof =>
            {
                cof.ToTable("Basket_Items");

            });

            modelBuilder.Entity<Basket>().HasMany(e => e.Items).WithMany().UsingEntity<BasketItems>(
                j => j.HasOne(e => e.Item).WithMany(), 
                j => j.HasOne(e => e.Basket).WithMany()
                );

            // modelBuilder.Entity<Basket>()
            //     .HasMany(x => x.Items)
            //     .WithMany();
            //

            // modelBuilder.Entity<BasketItems>(cof =>
            // {
            //     modelBuilder.Entity<BasketItems>()
            //         .HasKey(bi => new { bi.BasketId, bi.ItemId });
            //
            //     modelBuilder.Entity<BasketItems>()
            //         .HasOne(bi => bi.Basket)
            //         .WithMany(b => b.Items)
            //         .HasForeignKey(bi => bi.BasketId);
            //
            //     modelBuilder.Entity<BasketItems>()
            //         .HasOne(bi => bi.Item)
            //         .WithMany()
            //         .HasForeignKey(bi => bi.ItemId);
            // }); 


            // modelBuilder.Entity<Basket>().HasMany(x=> x.Items)
            //     .WithOne().HasForeignKey(); 
        }
    }
}