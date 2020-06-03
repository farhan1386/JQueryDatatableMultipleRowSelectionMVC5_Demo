using JQueryDatatableMultipleRowSelectionMvc_Demo.Models;
using System.Data.Entity;

namespace JQueryDatatableMultipleRowSelectionMvc_Demo.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("MultiSelectRowDB")
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}