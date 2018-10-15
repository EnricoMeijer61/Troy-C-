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
    public class ReservatiesController : Controller
    {
        // GET: Reservaties
        // aanroepen van het filter en de Serviceclient
        public ActionResult Index()
        {
            var filter = new Filter.Reservatie();
            var client = new ServiceClient();
            client.GetReservatie(filter);

            return View(client);
        }

        // GET: Reservaties/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var client = new ServiceClient();
            client.GetReservatieid(id.Value);

            if (client == null)
            {
                return HttpNotFound();
            }
            return View(client);
        }

        // GET: Reservaties/Create
        public ActionResult Create()
        {
            var model = new Models.ReservatieModel();
            return View();
        }

        // POST: Reservaties/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,datum,start,eind,gebruikerid,resortid,accomodatieid,dienstid")] Models.ReservatieModel data)
        {
            if (ModelState.IsValid)
            {
                IMapper mapper = Mapping.Config.ConfigMapping.Configureer();

                var content = mapper.Map<DataContract.Contract.Reservatie>(data);

                var client = new ServiceClient();
                client.UpdateReservatie(content);
                return RedirectToAction("Index");
            }
            return View(data);
        }

        // GET: Reservaties/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var client = new ServiceClient();
            var content = client.GetReservatieid(id.Value);
            if (content == null)
            {
                return HttpNotFound();
            }
            return View(content);
        }

        // POST: Reservaties/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,datum,start,eind,gebruikerid,resortid,accomodatieid,dienstid")] Models.ReservatieModel data)
        {
            if (ModelState.IsValid)
            {
                IMapper mapper = Mapping.Config.ConfigMapping.Configureer();

                var content = mapper.Map<DataContract.Contract.Reservatie>(data);
                var client = new ServiceClient();
                client.UpdateReservatie(content);

                return RedirectToAction("Index");
            }
            return View(data);
        }

        // GET: Reservaties/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var client = new ServiceClient();
            var content = client.GetReservatieid(id.Value);
            if (content == null)
            {
                return HttpNotFound();
            }
            return View(content);
        }

        // POST: Reservaties/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var client = new ServiceClient();
            client.DeleteReservatie(id);
            return RedirectToAction("Index");
        }
    }
}
