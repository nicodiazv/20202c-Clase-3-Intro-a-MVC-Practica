using Entidades;
using Microsoft.Ajax.Utilities;
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
                alimento.Peso = int.Parse(collection["Peso"]);

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
            Alimento alimento = AlimentosServicio.ObtenerPorId(id);
            return View(alimento);
        }

        // POST: Alimentos/Editar/5
        [HttpPost]
        public ActionResult Editar(Alimento alimento)
        {
            try
            {
                // TODO: Add update logic here
                AlimentosServicio.Editar(alimento);
                return RedirectToAction("Todos");
            }
            catch
            {
                return View();
            }
        }

        // GET: Alimentos/Borrar/5
        public ActionResult Borrar(int id)
        {
            AlimentosServicio.Borrar(id);
            return RedirectToAction("Todos");
        }

        
    }
}
