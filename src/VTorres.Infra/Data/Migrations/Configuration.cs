using System.Data.Entity.Migrations;
using VTorres.Infra.Data.Context;

namespace VTorres.Infra.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }
    }
}
