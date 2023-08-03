using Microsoft.EntityFrameworkCore;
using Treinar.Data.ClienteDbContext.Entidades;

namespace Treinar.Data.ClienteDbContext;

public class ClienteDbContext : DbContext
{
    public ClienteDbContext(DbContextOptions<ClienteDbContext> options) : base(options)
    {
        
    }

    public DbSet<Cliente> ClienteModels { get; set; }
    

}