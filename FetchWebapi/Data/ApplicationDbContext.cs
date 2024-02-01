using Microsoft.EntityFrameworkCore;
using FetchWebapi.Model;
namespace FetchWebapi.Data{

public class Appdbcontext:DbContext{
    public Appdbcontext(DbContextOptions<DbContext> options) : base(options)
    {
        
    }
    public DbSet<MovieDetails> MovieDetails{get; set;}
    
}
}