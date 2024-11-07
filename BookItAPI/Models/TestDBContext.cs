using Microsoft.EntityFrameworkCore;

namespace BookitAPI.Models
{
    public partial class TestDBContext : DbContext
    {

        public TestDBContext(DbContextOptions
        <TestDBContext> options)
            : base(options)
        {
        }
        public virtual DbSet<User> User { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(k => k.UserId);
            });
            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }

}