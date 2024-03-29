﻿using BlazorCRUDEmpresas.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorCRUDEmpresas.Data
{
    public class AppDbContext :DbContext
    {
        public DbSet<Company> Companies { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
        }

    }
}
