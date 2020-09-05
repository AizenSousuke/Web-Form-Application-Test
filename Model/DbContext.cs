namespace WebApplicationTest.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DbContext : System.Data.Entity.DbContext
    {
        public DbContext()
            : base("name=Default")
        {
        }
        public DbSet<SampleDataBindingModel> SampleDataBindingModels { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}
