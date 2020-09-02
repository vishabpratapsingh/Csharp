﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvc1.Models
{
    public class RazorPagesMovieContext : DbContext
    {
      public RazorPagesMovieContext(DbContextOptions<RazorPagesMovieContext> options)
    : base(options)
        {
        }

        public DbSet<RazorPagesMovie.Models.Movie> Movie { get; set; }

    }
}
