using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace georgia
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) :base(options)
        {
        }

        public DbSet<Photo> Photo { get; set; }

    }
}
