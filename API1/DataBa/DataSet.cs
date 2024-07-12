using API1.Entities;
using Microsoft.EntityFrameworkCore;


namespace API1.DataBa;

public class DataSet(DbContextOptions options) : DbContext(options)
{
  public DbSet<AddCustom> MyCustomer { get; set; }
}
