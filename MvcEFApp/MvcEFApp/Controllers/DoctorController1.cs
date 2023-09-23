using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MvcEFApp.Models;

namespace MvcEFApp.Controllers
{
    public class DoctorController1 : Controller
    {
        // GET: DoctorController1
        public ActionResult Index()
        {
            List<Doctor> Doctors = RepositoryDoctor.GetDoctor();
            if(Doctors !=null && Doctors.Count>0)
                return View(Doctors);
            else
                return RedirectToAction("Create");
        }

        // GET: DoctorController1/Details/5
        public ActionResult Details(int id)
        {
            Doctor doctor = RepositoryDoctor.GetDoctorById(id);
            return View(doctor);
        }

        // GET: DoctorController1/Create
        public ActionResult Create()
        {
            
            return View();
        }

        // POST: DoctorController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection,Doctor pdoctor)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    RepositoryDoctor.AddNewdoctor(pdoctor);
                }
                return RedirectToAction(nameof(Index));
            }
            catch(Exception err)
            {
                return View();
            }
        }

        // GET: DoctorController1/Edit/5
        public ActionResult Edit(int id)
        {
            Doctor doctor=RepositoryDoctor.GetDoctorById(id);
            return View(doctor);
        }

        // POST: DoctorController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection, Doctor doctor)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    RepositoryDoctor.ModifyDoctor(doctor);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DoctorController1/Delete/5
        public ActionResult Delete(int id)
        {
            Doctor doctor = RepositoryDoctor.GetDoctorById(id);
            return View(doctor);
        }

        // POST: DoctorController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    RepositoryDoctor.RemoveDoctor(id);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
