using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Skoomber.Models;


namespace Skoomber.Controllers
{
    public class ClientController : Controller
    {
        // GET: Client
        public ActionResult Index()
        {
            using(SkoomberEntities db = new SkoomberEntities())
            {
                return View(db.Clients.ToList());
            }
            
        }

        // GET: Client/Details/5
        public ActionResult Details(int id)
        {
            using (SkoomberEntities db = new SkoomberEntities())
            {
                return View(db.Clients.Where(x => x.ClientID == id).FirstOrDefault());
            }
            
        }

        // GET: Client/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Client/Create
        [HttpPost]
        public ActionResult Create(Client client)
        {
            try
            {
                // TODO: Add insert logic here

                using(SkoomberEntities db = new SkoomberEntities())
                {
                    db.Clients.Add(client);
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Client/Edit/5
        public ActionResult Edit(int id)
        {
            using (SkoomberEntities db = new SkoomberEntities())
            {
                return View(db.Clients.Where(x => x.ClientID == id).FirstOrDefault());
            }
        }

        // POST: Client/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Client client)
        {
            try
            {
                // TODO: Add update logic here
                using (SkoomberEntities db = new SkoomberEntities())
                {
                    db.Entry(client).State = EntityState.Modified;
                    db.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Client/Delete/5
        public ActionResult Delete(int id)
        {
            using (SkoomberEntities db = new SkoomberEntities())
            {
                return View(db.Clients.Where(x => x.ClientID == id).FirstOrDefault());
            }
        }

        // POST: Client/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Client client)
        {
            try
            {
                // TODO: Add delete logic here

                using(SkoomberEntities db = new SkoomberEntities())
                {
                    client = db.Clients.Where(x => x.ClientID == id).FirstOrDefault();
                    db.Clients.Remove(client);
                    db.SaveChanges();
                    

                }

                return RedirectToAction("Index");
            }

                
        
            catch
            {
                return View();
            }
        }
    }
}
