using Microsoft.EntityFrameworkCore;
using Portfolio;
using Microsoft.Extensions.Options;
namespace Portfolio
{

    public partial class PortfolioContext : DbContext
    {
        public DbSet<SkillTable>        Skill          { get; set; }
        public DbSet<ExperienceTable>   Experience     { get; set; }
        public DbSet<SkillCategoryTable> SkillCategory { get; set; }
        public DbSet<EducationTable> Education { get; set; }

     
        public PortfolioContext(DbContextOptions<PortfolioContext> options): base(options) {}

        protected override void OnModelCreating(ModelBuilder builder)
        {

            base.OnModelCreating(builder);
            builder.Entity<SkillTable>().ToTable("Skill");
            builder.Entity<ExperienceTable>().ToTable("Experience").HasMany(e => e.Skills).WithMany(s => s.Experiences);
            builder.Entity<SkillCategoryTable>().ToTable("SkillCategory").HasMany(s => s.Skills).WithMany(s => s.Categories);
            builder.Entity<EducationTable>().ToTable("Education");

        }
    }
}