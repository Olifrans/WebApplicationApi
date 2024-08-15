using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplicationApi.Modelo;

namespace WebApplicationApi.Models
{
    public class WebApplicationApiContext : DbContext
    {
        public WebApplicationApiContext (DbContextOptions<WebApplicationApiContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplicationApi.Modelo.Aluno> Aluno { get; set; }

        public DbSet<WebApplicationApi.Modelo.Curso> Curso { get; set; }
    }
}
