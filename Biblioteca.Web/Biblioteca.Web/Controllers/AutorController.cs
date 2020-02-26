using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using Biblioteca.Application.Execution.Commands;
using Biblioteca.Application.Execution.Queries;
using Biblioteca.Domain.Entities;
using Biblioteca.Domain.Models;
using Biblioteca.Persistence;

namespace Biblioteca.Web.Controllers
{
    public class AutorController : Controller
    {
        private BibliotecaDbContext db = new BibliotecaDbContext();
        // GET: Autor
        public ActionResult Index()
        {
            List<AutorViewModel> listAutores = new List<AutorViewModel>();
            QueryAutor queryAutor = new QueryAutor(db);
            var request = queryAutor.getAllAutores();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Autor, AutorViewModel>();
            });
            IMapper iMapper = config.CreateMapper();

            foreach (var item in request)
            {
                listAutores.Add(iMapper.Map<Autor, AutorViewModel>(item));
            }

            return View(listAutores);
        }

        // GET: Autor/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QueryAutor queryAutor = new QueryAutor(db);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Autor, AutorViewModel>();
            });
            IMapper iMapper = config.CreateMapper();

            Autor request = queryAutor.getAutorXId((int) id);
            if (request == null)
            {
                return HttpNotFound();
            }
            var autor = iMapper.Map<Autor, AutorViewModel>(request);
            return View(autor);
        }

        // GET: Autor/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Autor/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdAutor,Nombre,Nacionalidad")] AutorViewModel autor)
        {
            if (ModelState.IsValid)
            {
                CommandAutor commandAutor = new CommandAutor(db);
                var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<AutorViewModel, Autor>();
                });
                IMapper iMapper = config.CreateMapper();
                Autor entity = iMapper.Map<AutorViewModel, Autor>(autor);

                if (commandAutor.createAutor(entity) == true)
                    return RedirectToAction("Index");
                else
                    return View(autor);
            }

            return View(autor);
        }

        // GET: Autor/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QueryAutor queryAutor = new QueryAutor(db);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Autor, AutorViewModel>();
            });
            IMapper iMapper = config.CreateMapper();

            Autor request = queryAutor.getAutorXId((int)id);

            if (request == null)
            {
                return HttpNotFound();
            }
            var autor = iMapper.Map<Autor, AutorViewModel>(request);
            return View(autor);
        }

        // POST: Autor/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdAutor,Nombre,Nacionalidad")] AutorViewModel autor)
        {
            if (ModelState.IsValid)
            {
                CommandAutor commandAutor = new CommandAutor(db);
                var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<AutorViewModel, Autor>();
                });
                IMapper iMapper = config.CreateMapper();

                Autor entity = iMapper.Map<AutorViewModel, Autor>(autor);

                if (commandAutor.updateAutor(entity) == true)
                    return RedirectToAction("Index");
                else
                    return View(autor);
            }
            return View(autor);
        }

        // GET: Autor/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QueryAutor queryAutor = new QueryAutor(db);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Autor, AutorViewModel>();
            });
            IMapper iMapper = config.CreateMapper();

            Autor request = queryAutor.getAutorXId((int)id);

            if (request == null)
            {
                return HttpNotFound();
            }
            var autor = iMapper.Map<Autor, AutorViewModel>(request);
            return View(autor);
        }

        // POST: Autor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CommandAutor commandAutor = new CommandAutor(db);

            commandAutor.deleteAutor(id);

            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
