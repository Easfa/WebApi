using Microsoft.EntityFrameworkCore;

namespace WebApi.DataAccess
{
    public class ApiImContext : DbContext
    {
        public ApiImContext(DbContextOptions options) : base(options) { }
    }
}
