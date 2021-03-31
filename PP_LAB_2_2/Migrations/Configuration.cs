namespace PP_LAB_2_2.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PP_LAB_2_2.records>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "PP_LAB_2_2.records";
        }

        protected override void Seed(PP_LAB_2_2.records context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
