namespace WhoLetDerHundOut.DataContextMigrations
{
    using WhoLetDerHundOut.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WhoLetDerHundOut.Models.MemberDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"DataContextMigrations";
        }

        protected override void Seed(WhoLetDerHundOut.Models.MemberDBContext context)
        {
            var member = new List<Membership>
{
new Membership{fname="Kam",lname="Reffitt",gender="male", age=50},
new Membership{fname="Wilma",lname="Flintstone",gender="female", age=45},
new Membership{fname="Freddie",lname="Flintstone",gender="male", age=50},
new Membership{fname="Pebbles",lname="Flintstone",gender="female", age=25},
new Membership{fname="Scooby",lname="Doo",gender="male", age=25}
};
            member.ForEach(m => context.Members.AddOrUpdate(m));
            context.SaveChanges();
        }
    }
}
