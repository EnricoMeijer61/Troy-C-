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
    public class DienstsController : Controller
    {
        // GET: Diensts
        // aanroepen van het filter en de Serviceclient
        public ActionResult Index()
        {
            var filter = new Filter.Dienst();
            var client = new ServiceClient();
            client.GetDienst(filter);

            return View(client);
        }

        // GET: Diensts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var client = new ServiceClient();
            client.GetDienstid(id.Value);

            if (client == null)
            {
                return HttpNotFound();
            }
            return View(client);
        }

        // GET: Diensts/Create
        public ActionResult Create()
        {
            var model = new Models.DienstModel();
        
            return View(model);
        }

        // POST: Diensts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,dienst,zorg,resortid")] Models.DienstModel data)
        {
            if (ModelState.IsValid)
            {
                IMapper mapper = Mapping.Config.ConfigMapping.Configureer();

                var content = mapper.Map<DataContract.Contract.Dienst>(data);

                var client = new ServiceClient();
                client.UpdateDienst(content);
                return RedirectToAction("Index");
            }
            return View(data);
        }

        // GET: Diensts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var client = new ServiceClient();
            var content = client.GetDienstid(id.Value);
            if (content == null)
            {
                return HttpNotFound();
            }
            return View(content);
        }

        // POST: Diensts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,dienst,zorg,resortid")] Models.DienstModel data)
        {
            if (ModelState.IsValid)
            {
                IMapper mapper = Mapping.Config.ConfigMapping.Configureer();

                var content = mapper.Map<DataContract.Contract.Dienst>(data);
                var client = new ServiceClient();
                client.UpdateDienst(content);

                return RedirectToAction("Index");
            }
            return View(data);
        }

        // GET: Diensts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var client = new ServiceClient();
            var content = client.GetDienstid(id.Value);

            if (content == null)
            {
                return HttpNotFound();
            }
            return View(content);
        }

        // POST: Diensts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var client = new ServiceClient();
            client.DeleteDienst(id);
            return RedirectToAction("Index");
        }
    }
}
