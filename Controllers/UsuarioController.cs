using System;
using Microsoft.AspNetCore.Mvc;
using MVCBD.Db;
using System.Linq;
using System.Collections.Generic;

namespace MVCBD.Controllers
{
    public class UsuarioController: Controller
    {   
        

         public IActionResult Index()
        {
            using (var r = new RolContext())
            {
               List<user> usuariosJ = r.usuarios.ToList();
               List<rol> rolJ = r.rol.ToList();
               List<aux> userandrolJ = r.aux.ToList();

               var tablasJ = from c in userandrolJ
               join st in rolJ on c.idRol equals st.idRol into tablas1
               from st in tablas1.DefaultIfEmpty()
               join ct in usuariosJ on c.idUsuario equals ct.idUsuario into table2
               from ct in table2.DefaultIfEmpty()
               select new UserAndRolsModel {usuarioRolesDetails = c,rolDetails =st,usuarioDetail = ct};
               return View(tablasJ);
            }
        }

        public IActionResult Create(rol roles){
            
            using (var r = new RolContext())
            {
            if(roles.idRol == 0)
            {
                ModelState.AddModelError("","Selecciona un rol");
            }
            int Sel = roles.idRol;
            ViewBag.SelectedValue = roles.idRol;

            List<rol> rol = new List<Db.rol>();
            rol = (from Roles in r.rol
            select Roles).ToList();

            rol.Insert(0,new rol{idRol = 0, nombreRol = "Selecciona "});
            ViewBag.ListofRoles = rol;

            return View("Registro");
            }
        
        }

        [HttpPost]
        public IActionResult Save( int userid, string username, string userpass,int select_rol){
            using (var r= new RolContext()){
        
                var nuevoUsuario=new user(){
                    idUsuario=userid,
                    nombreUsuario=username,
                    contraseñaUsuario=userpass
                };
                var userAndRol=new aux(){
                    idUsuario=userid,
                    idRol=select_rol
                    
                };
            var usuarios =r.usuarios.Add(nuevoUsuario);
            var userRol =r.aux.Add(userAndRol);
            r.SaveChanges();
            return RedirectToAction("Index");
            }
        
        }

         public IActionResult Edit(int ? id){
             using (var r= new RolContext())
             {
                 var usuario = r.usuarios.Single(n=> n.idUsuario==id);
                  return View(usuario);
             }
           
        }

        [HttpPost]
         public IActionResult EditSave(int userid, string username, string userpass){
             using (var r= new RolContext()){
                 var usuario=r.usuarios.Single(n => n.idUsuario ==userid);
                 usuario.nombreUsuario=username;
                 usuario.contraseñaUsuario=userpass;                 
                 r.SaveChanges();
                 return RedirectToAction("Index");
            }
    
        }

         //  [HttpPost]
            public IActionResult Delete(int? id){
             using (var r= new RolContext()){
                 var usuario=r.usuarios.Single(n => n.idUsuario ==id);
                 r.Remove(usuario);
                 r.SaveChanges();
                 return RedirectToAction("Index");
             }
            }
    }
}