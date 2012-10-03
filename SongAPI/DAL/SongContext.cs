using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using SongAPI.Models;

namespace SongAPI.DAL
{
    public class SongContext : DbContext
    {
        public DbSet<Song> Songs { get; set; }

        public SongContext()
            : base("context")
        { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<SongContext, Configuration>());
        }
    }
}