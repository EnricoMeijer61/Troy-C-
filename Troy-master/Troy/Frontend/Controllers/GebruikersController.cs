using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DataContract.Contract;
using Frontend.Models;
using AutoMapper;
using Filter = DataContract.Filters;
using Frontend.Service;

namespace Frontend.Controllers
{
    public class GebruikersController : Controller
    {
        // GET: Gebruikers
        // aanroepen van het filter en de Serviceclient
        public ActionResult Index()
        {
            var filter = new Filter.Gebruiker();
            var client = new ServiceClient();
            client.GetGebruiker(filter);

            return View(client);
        }

        // GET: Gebruikers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var client = new ServiceClient();
            client.GetAccomodatieid(id.Value);

            if (client == null)
            {
                return HttpNotFound();
            }
            return View(client);
        }

        // GET: Gebruikers/Create
        public ActionResult Create()
        {
            var model = new Models.GebruikerModel();
            return View(model);
        }

        // POST: Gebruikers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,naam,achternaam,geboortedatum")] Models.GebruikerModel data)
        {
            if (ModelState.IsValid)
            {
                IMapper mapper = Mapping.Config.ConfigMapping.Configureer();

                var content = mapper.Map<DataContract.Contract.Gebruiker>(data);

                var client = new ServiceClient();
                client.UpdateGebruiker(content);
                return RedirectToAction("Index");
            }
            return View(data);
        }

        // GET: Gebruikers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var client = new ServiceClient();
            var content = client.GetGebruikerid(id.Value);
            if (content == null)
            {
                return HttpNotFound();
            }
            return View(content);
        }

        // POST: Gebruikers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,naam,achternaam,geboortedatum")] Models.GebruikerModel data)
        {
            if (ModelState.IsValid)
            {
                IMapper mapper = Mapping.Config.ConfigMapping.Configureer();

                var content = mapper.Map<DataContract.Contract.Gebruiker>(data);
                var client = new ServiceClient();
                client.UpdateGebruiker(content);

                return RedirectToAction("Index");
            }
            return View(data);
        }

        // GET: Gebruikers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var client = new ServiceClient();
            var content = client.GetGebruikerid(id.Value);
            if (content == null)
            {
                return HttpNotFound();
            }
            return View(content);
        }

        // POST: Gebruikers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var client = new ServiceClient();
            client.DeleteGebruiker(id);
            return RedirectToAction("Index");
        }
    }
}
