using RolodexWithSQLServer.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RolodexWithSQLServer.Models {
    public class DataContext : DbContext {
        public IDbSet<Contact> Contacts { get; set; }
        public IDbSet<Address> Addresses { get; set; }

        static DataContext() {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DataContext, Configuration>());
        }
        
    }

}