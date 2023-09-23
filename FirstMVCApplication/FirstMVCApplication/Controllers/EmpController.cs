using FirstMVCApp.Models;
using FirstMVCApplication.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace FirstMVCApplication.Controllers
{
    public class EmpController : Controller
    {
        // GET: EmpController
        public ActionResult Index()
        {
            List<Employee> Emplist = EmpDbRepository.GetEmpList();
            return View(Emplist);
        }

        // GET: EmpController/Details/5
        public ActionResult Details(int id)
        {
            if(id<=0)
            {
                return RedirectToAction("Index");
            }
            Employee Emp = EmpDbRepository.GetEmpById(id);
            return View(Emp);
        }

        // GET: EmpController/Create
        public ActionResult Create()
        {
            Employee Emp = new Employee();
            return View(Emp);
        }

        // POST: EmpController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection,Employee pemp)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    EmpDbRepository.AddNewEmp(pemp);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmpController/Edit/5
        public ActionResult Edit(int id)
        {
            if (id<=0)
            {
                return RedirectToAction("India");
            }
            Employee Emp= EmpDbRepository.GetEmpById(id);
            return View(Emp);
        }

        // POST: EmpController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection,Employee pemp)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    EmpDbRepository.UpdateEmp(pemp);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmpController/Delete/5
        public ActionResult Delete(int id)
        {
            if(id<=0)
            {
                return RedirectToAction("Index");
            }
            Employee Emp=EmpDbRepository.GetEmpById(id);
            return View(Emp);
        }

        // POST: EmpController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    EmpDbRepository.DeleteEmp(id);
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
