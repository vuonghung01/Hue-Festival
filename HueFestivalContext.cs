using Hue_Festival.Data;
using Microsoft.EntityFrameworkCore;

namespace Hue_Festival
{
    public class HueFestivalContext : DbContext
    {
        public HueFestivalContext(DbContextOptions<HueFestivalContext> opt): base(opt) { }

        public DbSet<Event>? Events { get; set; }
        public DbSet<EventLiked>? EventLikeds { get; set; }
        public DbSet<Location>? Locations { get; set; }
        public DbSet<LocationLiked>? LocationLikeds { get; set; }
        public DbSet<LocationType>? LocationTypes { get; set; }
        public DbSet<News>? News { get; set; }
        public DbSet<NewsLiked>? NewsLikeds { get; set; }
        public DbSet<Programm>? Programms { get; set; }
        public DbSet<ProgramImage>? ProgramImages { get; set; }
        public DbSet<Role>? Roles { get; set; }
        public DbSet<SupportMenu>? SupportMenus { get; set; }
        public DbSet<Ticket>? Tickets { get; set; }
        public DbSet<TicketType>? TicketTypes { get; set; }
        public DbSet<User>? Users { get; set; }
    }
}
