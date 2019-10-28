using System;
using Microsoft.AspNetCore.Mvc;
using MVCBD.Db;
using System.Linq;

namespace MVCBD.Controllers
{
    public class RolController: Controller
    {
         public IActionResult Index()
        {
            using (var r = new RolContext())
            {
               var rol = r.rol.ToList();
               return View(rol);
            }
        }

        public IActionResult Create(){
            return View("Registro");
        }

        [HttpPost]
        public IActionResult Save( int rid, string rname){
            using (var r= new RolContext()){
                Console.WriteLine(rid);
                Console.WriteLine(rname);
                var nuevoRol=new rol(){
                    idRol=rid,
                    nombreRol=rname
                };
            var roles =r.rol.Add(nuevoRol);
            r.SaveChanges();
            return RedirectToAction("Index");
            }
        
        }

         public IActionResult Edit(int ? id){
             using (var r= new RolContext())
             {
                 var rol = r.rol.Single(n=> n.idRol==id);
                  return View(rol);
             }
           
        }

        [HttpPost]
         public IActionResult EditSave(int rid, string rname){
             using (var r= new RolContext()){
                 var rol=r.rol.Single(n => n.idRol ==rid);
                 rol.nombreRol=rname;
                 r.SaveChanges();
                 return RedirectToAction("Index");
            }
    
        }

         //  [HttpPost]
            public IActionResult Delete(int? id){
             using (var r= new RolContext()){
                 var rol=r.rol.Single(n => n.idRol ==id);
                 r.Remove(rol);
                 r.SaveChanges();
                 return RedirectToAction("Index");
             }
            }
    }
}