using Microsoft.EntityFrameworkCore;

namespace BulkyMVC.Data
{
    public class ApplicationDbContex: DbContext
    {
        public ApplicationDbContex(DbContextOptions<ApplicationDbContex>options) : base(options)
        {

        }
      
    }
}
