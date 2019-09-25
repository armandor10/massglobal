using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace masglobal.Controllers
{
    public class EmployedController : Controller
    {
        private string baseUrl = "http://localhost:58052/api";
        // GET: Employed    
        public ActionResult Index(int id = 0)
        {
            var rest = new REST();
            List<EmployedDTO> employes;
            ResponseDTO resp;
            if (id == 0)
            {
                resp = JsonConvert.DeserializeObject<ResponseDTO>(rest.Get(baseUrl + "/employed"));
                employes = JsonConvert.DeserializeObject<List<EmployedDTO>>(resp.data.ToString());
            } else
            {
                resp = JsonConvert.DeserializeObject<ResponseDTO>(rest.Get(baseUrl + "/employed/" + id));
                var employed = JsonConvert.DeserializeObject<EmployedDTO>(resp.data.ToString());
                employes = new List<EmployedDTO>();
                employes.Add(employed);
            }
            return View(employes);
        }

        // GET: Employed/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Employed/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employed/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Employed/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Employed/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Employed/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Employed/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}