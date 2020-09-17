﻿using Entidades;
using Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroMVC.Controllers
{
    public class AlimentosController : Controller
    {

        AlimentosServicio AlimentosServicio = new AlimentosServicio();
        // GET: Alimentos/todos
        public ActionResult Todos()
        {
            List<Alimento> todos = AlimentosServicio.ObtenerTodos();
            return View(todos);
            
        }

        

        // GET: Alimentos/Alta
        public ActionResult Alta()
        {
            return View();
        }

        // GET: Alimentos/Crear
        public ActionResult Crear()
        {
            return View();
        }

        // POST: Alimentos/Crear
        [HttpPost]
        public ActionResult Crear(FormCollection collection)
        {
            try
            {
                Alimento alimento = new Alimento();
                alimento.Nombre = collection["Nombre"];
                alimento.Nombre = collection["Peso"];

                AlimentosServicio.Crear(alimento);

                return RedirectToAction("Todos");
            }
            catch
            {
                return View();
            }
        }

        // GET: Alimentos/Editar/5
        public ActionResult Editar(int id)
        {
            return View();
        }

        // POST: Alimentos/Editar/5
        [HttpPost]
        public ActionResult Editar(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Alimentos/Borrar/5
        public ActionResult Borrar(int id)
        {
            return View();
        }

        // POST: Alimentos/Borrar/5
        [HttpPost]
        public ActionResult Borrar(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
