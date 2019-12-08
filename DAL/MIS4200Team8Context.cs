using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MIS4200Team8v2.Models;
using System.Data.Entity;

namespace MIS4200Team8v2.DAL
{
    public class MIS4200Team8Context : DbContext
    {
        public MIS4200Team8Context() : base ("DefaultConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MIS4200Team8Context, MIS4200Team8v2.Migrations.MISContext.Configuration>("DefaultConnection"));
        }
        public DbSet<userDetail> userDetails{ get; set; }
        public DbSet<sendPoints> sendPointss { get; set; }
        public DbSet<coreValues> coreValuess { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public System.Data.Entity.DbSet<MIS4200Team8v2.Models.Recognition> Recognitions { get; set; }
    }
}