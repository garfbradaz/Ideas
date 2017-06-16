using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ideas.Models
{
    public class IdeaContext       : DbContext
    {
        public IdeaContext(DbContextOptions<IdeaContext> options)
            : base(options)
        { }

        public DbSet<Idea> Ideas { get; set; }
    }
}
