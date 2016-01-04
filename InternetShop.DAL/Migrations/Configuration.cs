namespace InternetShop.DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<InternetShop.DAL.EF.EFContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "InternetShop.DAL.EF.EFContext";
        }

        protected override void Seed(InternetShop.DAL.EF.EFContext context)
        {
            
        }
    }
}
