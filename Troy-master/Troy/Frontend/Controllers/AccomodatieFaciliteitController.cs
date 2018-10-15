using System.Net;
using System.Web.Mvc;
using AutoMapper;
using Filter = DataContract.Filters;
using Frontend.Service;
//copieer de "using" namespaces ^

namespace Frontend.Controllers
{
    public class AccomodatieFaciliteitController : Controller
    {

        // GET: AccomodatieFaciliteits
        public ActionResult Index()
        {
            var filter = new Filter.AccomodatieFaciliteit(); //spreekt het filter aan 
            var client = new ServiceClient(); //opent de ServiceClient
            client.GetAccomodatieFaciliteit(filter);

            return View(client); // geeft de view terug
        }

        // GET: AccomodatieFaciliteits/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var client = new ServiceClient();
            client.GetAccomodatieFaciliteitid(id.Value);

            if (client == null)
            {
                return HttpNotFound();
            }
            return View(client);
        }

        // GET: AccomodatieFaciliteits/Create
        public ActionResult Create()
        {
            var model = new Models.AccomodatieFaciliteitModel();
            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,faciliteit,accomodatieid")] Models.AccomodatieFaciliteitModel data)
        {
            if (ModelState.IsValid)
            {
                IMapper mapper = Mapping.Config.ConfigMapping.Configureer();

                var content = mapper.Map<DataContract.Contract.AccomodatieFaciliteit>(data);

                var client = new ServiceClient();
                client.UpdateAccomodatieFaciliteit(content);
                return RedirectToAction("Index");
            }
            return View(data);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var client = new ServiceClient();
            var content = client.GetAccomodatieFaciliteitid(id.Value);
            if (content == null)
            {
                return HttpNotFound();
            }
            return View(content);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,faciliteit,accomodatieid")] Models.AccomodatieFaciliteitModel data)
        {
            if (ModelState.IsValid)
            {
            IMapper mapper = Mapping.Config.ConfigMapping.Configureer();

            var content = mapper.Map<DataContract.Contract.AccomodatieFaciliteit>(data);
            var client = new ServiceClient();
            client.UpdateAccomodatieFaciliteit(content);

            return RedirectToAction("Index");
            }
            return View(data);
        }

        // GET: AccomodatieFaciliteits/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var client = new ServiceClient();
            var content = client.GetAccomodatieFaciliteitid(id.Value);

            if (content == null)
            {
                return HttpNotFound();
            }
            return View(content);
            
        }

        // POST: AccomodatieFaciliteits/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var client = new ServiceClient();
            client.DeleteAccomodatieFaciliteit(id);
            return RedirectToAction("Index");
        }
    }
}
