using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Transportation.EntityLayer.Entities;

namespace Transportation.DataAccessLayer.Context
{
    public class TransportationContext:IdentityDbContext<AppUser,AppRole,int>
    {
        public TransportationContext(DbContextOptions<TransportationContext> options):base(options)
        {
            
        }
        public DbSet<Message> Messages { get; set; }
        public DbSet<TeamMember> TeamMembers { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<TransportTeam> TransportTeams { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<TransportRequest> TransportRequests { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<RequestType> RequestTypes { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);


            builder.Entity<Message>()
               .HasOne(m => m.SenderUser)
               .WithMany(u => u.SentMessages)
               .HasForeignKey(m => m.SenderUserId)
               .OnDelete(DeleteBehavior.ClientSetNull);
           builder.Entity<Message>()
                .HasOne(m=>m.ReceiverUser)
                .WithMany(m=>m.ReceivedMessages)
                .HasForeignKey(m=>m.ReceiverUserId)
                .OnDelete(DeleteBehavior.ClientSetNull);
            builder.Entity<Reservation>()
                .HasOne(r => r.TransportRequest)
                .WithOne(tr => tr.Reservation)
                .HasForeignKey<Reservation>(r => r.TransportRequestId);

            builder.Entity<TransportRequest>()
                .HasOne(tr => tr.Reservation)
                .WithOne(r => r.TransportRequest);
            builder.Entity<Reservation>()
                .HasOne(r => r.Vehicle)
                .WithMany()
                .HasForeignKey(r => r.VehicleId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        
    }
}
