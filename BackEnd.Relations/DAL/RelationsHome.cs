using BackEnd.Relations.Entities;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.Relations.DAL
{
    public class RelationsHome:DbContext
    {
        public RelationsHome(DbContextOptions<RelationsHome> options):base(options)
        {
            
        }
        public DbSet<Chef> Chefs { get; set; }
        public DbSet<ChefSocialMedia> ChefSocialMedias { get; set; }
        public DbSet<Profession> Professions { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }


    }
}
