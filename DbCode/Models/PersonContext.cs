﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DbCode.Models
{
    public class PersonContext : DbContext
    {
        public PersonContext(DbContextOptions options) : base(options)
        {
           
        }

        public DbSet<Person> Person { get; set; }
        
    }
}
