using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUD_Proyecto.Controllers
{
    public class EstudianteCursoController : Controller
    {
        // GET: EstudianteCurso
        public ActionResult Index()
        {
            return View();
        }

        // GET: EstudianteCurso/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EstudianteCurso/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EstudianteCurso/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: EstudianteCurso/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EstudianteCurso/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
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

        // GET: EstudianteCurso/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EstudianteCurso/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
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
