using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RolodexWithSQLServer.Models {
    public class DatabaseInitializer : DropCreateDatabaseAlways<DataContext> {

    }
}