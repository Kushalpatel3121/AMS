using AMS.Models;
using AMS.web.Models;
using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace AMS.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions options, IOptions<OperationalStoreOptions> operationalStoreOptions)
            : base(options, operationalStoreOptions)
        {

        }
        public DbSet<Karyakar> Karyakar { get; set; }
        public DbSet<Kshetra> Kshetra { get; set; }
        public DbSet<Mandal> Mandal { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Sabha> Sabha { get; set; }
        public DbSet<SabhaAttendance> SabhaAttendance { get; set; }
        public DbSet<SamparkKaryakar> SamparkKaryakar { get; set; }
        public DbSet<Sanchalak> Sanchalak { get; set; }
        public DbSet<Yuvak> Yuvak { get; set; }
    }
}