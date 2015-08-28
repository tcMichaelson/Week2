using RolodexWithSQLServer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RolodexWithSQLServer.Controllers
{
    public class ContactsController : Controller
    {
        private DataContext _db = new DataContext();

        // GET: Contacts
        public ActionResult Index()
        {
            var contacts = (from c in _db.Contacts.Include(c => c.Address) select c).ToList();
            return View(contacts);
        }


        public ActionResult Create() {
            return View();
        }

        // POST: Random/Create
        [HttpPost]
        public ActionResult Create(Contact collection) {
            try {
                // TODO: Add insert logic here
                _db.Contacts.Add(collection);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch 
        {
                return View();
            }
        }

        public ActionResult Edit(int id) {
            var contact = _db.Contacts.Find(id);
            return View(contact);
        }

        [HttpPost]
        public ActionResult Edit(int id, Contact contact) {
            try {
                if (ModelState.IsValid) {
                    var dbContact = _db.Contacts.Find(id);
                    dbContact.Name = contact.Name;
                    dbContact.Phone = contact.Phone;
                    dbContact.Birthday = contact.Birthday;
                                        
                    _db.SaveChanges();

                    return RedirectToAction("Index");
                } else {
                    return View();
                }
            }catch {
                return View();
            }
        }
    }
}