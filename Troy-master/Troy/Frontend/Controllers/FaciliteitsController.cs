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
    public class FaciliteitsController : Controller
    {
        // GET: Faciliteits
        // aanroepen van het filter en de Serviceclient
        public ActionResult Index()
        {
            var filter = new Filter.Faciliteit();
            var client = new ServiceClient();
            client.GetFaciliteit(filter);

            return View(client);
        }

        // GET: Faciliteits/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var client = new ServiceClient();
            client.GetFaciliteitid(id.Value);

            if (client == null)
            {
                return HttpNotFound();
            }
            return View(client);
        }

        // GET: Faciliteits/Create
        public ActionResult Create()
        {
            var model = new Models.FaciliteitModel();
            return View(model);  
        }

        // POST: Faciliteits/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,faciliteit,resortid")] Models.FaciliteitModel data)
        {
            if (ModelState.IsValid)
            {
                IMapper mapper = Mapping.Config.ConfigMapping.Configureer();

                var content = mapper.Map<DataContract.Contract.Faciliteit>(data);

                var client = new ServiceClient();
                client.UpdateFaciliteit(content);
                return RedirectToAction("Index");
            }
            return View(data);
        }

        // GET: Faciliteits/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var client = new ServiceClient();
            var content = client.GetFaciliteitid(id.Value);
            if (content == null)
            {
                return HttpNotFound();
            }
            return View(content);
        }

        // POST: Faciliteits/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,faciliteit,resortid")] Models.FaciliteitModel data)
        {
            if (ModelState.IsValid)
            {
                IMapper mapper = Mapping.Config.ConfigMapping.Configureer();

                var content = mapper.Map<DataContract.Contract.Faciliteit>(data);
                var client = new ServiceClient();
                client.UpdateFaciliteit(content);

                return RedirectToAction("Index");
            }
            return View(data);
        }

        // GET: Faciliteits/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var client = new ServiceClient();
            var content = client.GetFaciliteitid(id.Value);

            if (content == null)
            {
                return HttpNotFound();
            }
            return View(content);
        }

        // POST: Faciliteits/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var client = new ServiceClient();
            client.DeleteFaciliteit(id);
            return RedirectToAction("Index");
        }
    }
}
