using Microsoft.EntityFrameworkCore;

namespace BlogAPI.DataAccessLayer;

public class Context:DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Server=localhost,1401; Database=CoreBlogApiDb; User Id=sa; Password=YourSTRONG!Passw0rd;TrustServerCertificate=true");
    }

    public DbSet<Employee> Employees { get; set; }
}