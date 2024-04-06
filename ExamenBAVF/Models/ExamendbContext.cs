using Microsoft.EntityFrameworkCore;

namespace ExamenBAVF.Models
{
    public class ExamendbContext : DbContext
    {
        public ExamendbContext(DbContextOptions options): base (options) { 

        }    
    }
}
