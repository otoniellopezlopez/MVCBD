using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MVCBD.Db
{
 
    public class RolContext : DbContext
    {
           public DbSet<rol>rol{get;set;}
           public DbSet<user>usuarios{get;set;}
           public DbSet<aux>aux{get;set;}



           


           protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
               optionsBuilder.UseNpgsql("host=localhost;Database=Acceso;Uid=postgres;Password=Elite0416");

           }
           protected override void OnModelCreating(ModelBuilder modelBuilder){
             modelBuilder.Entity <user>().HasKey(x=>new {x.idUsuario});
             modelBuilder.Entity <aux>().HasKey(x=>new {x.idRol,x.idUsuario});
             modelBuilder.Entity <rol>().HasKey(x=>new {x.idRol});
           }
    }

    public class user
    {
        public int idUsuario { get; set; }
        public string nombreUsuario { get; set; }
        public string contraseñaUsuario { get; set; }
        
 
    }

    public class rol{ 
        
        public int idRol { get; set; }
        public string nombreRol { get; set; }

    }

    public class aux{
        public int idUsuario {get;set;}
        public int idRol {get;set;}
 
  }

  
  public class UserAndRolsModel
    {
        public user usuarioDetail { get; set; }
        public aux usuarioRolesDetails { get; set;}
        public  rol rolDetails {get;set;}
    }
}