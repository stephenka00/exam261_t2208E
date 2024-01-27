using Exam261.Model;
using Microsoft.EntityFrameworkCore;
namespace Exam261.DbFirst
{
    public class MyDbContext : DbContext
    {
            public MyDbContext(DbContextOptions options) : base(options)
            {

            }

            public DbSet<OrderTbl> OrderTbl { get; set; }

        }
    }



