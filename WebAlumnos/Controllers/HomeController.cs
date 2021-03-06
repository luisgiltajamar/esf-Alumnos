﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAlumnos.Models;

namespace WebAlumnos.Controllers
{
    public class HomeController : Controller
    {

        private CursosEntities db = new CursosEntities();

        // GET: Home
        public ActionResult Index()
        {
           

         

                return View(db.Alumnos.ToList());

            
        }

        public ActionResult Alta()
        {
            ViewBag.idNacionalidad = 
                new SelectList(db.Nacionalidades,"id","nombre");
            ViewBag.idCursos = new MultiSelectList(db.Curso, "id", "nombre");
            return View(new Alumnos());
        }

        [HttpPost]
        public ActionResult Alta(Alumnos model)
        {
            if (ModelState.IsValid)
            {
                
                db.Alumnos.Add(model);
                foreach (var idCurso in model.idCursos)
                {
                    var c = db.Curso.Find(idCurso);
                    model.Curso.Add(c);
                }
                db.SaveChanges();


                    return RedirectToAction("Index");
                
            }
            return View(model);
        }

      
        public ActionResult Buscar(String busqueda)
        {
          

            var db = new CursosEntities();

            var al = db.Alumnos.Where(o => o.apellidos.Contains(busqueda));
            return PartialView("_Listado",al);
        }

    }
}