﻿using FirstMVCApp.Models;
using FirstMVCApplication.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVCApplication.Controllers
{
    public class MovieController : Controller
    {
        // GET: MovieController
        public ActionResult Index()
        {
            List<Movie> Mvilist = MovieDbRepository.GetMviList();
            return View(Mvilist);
        }

        // GET: MovieController/Details/5
        public ActionResult Details(int id)
        {
            if (id <= 0)
            {
                return RedirectToAction("Index");
            }
            Movie Mvi = MovieDbRepository.GetMviByName(id);
            return View(Mvi);
        }

        // GET: MovieController/Create
        public ActionResult Create()
        {
            Movie Mvi = new Movie();
            return View(Mvi);
        }

        // POST: MovieController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection, Movie pmvi)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    MovieDbRepository.AddNewMvi(pmvi);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MovieController/Edit/5
        public ActionResult Edit(int id)
        {
            if (id <= 0)
            {
                return RedirectToAction("India");
            }
            Movie Mvi = MovieDbRepository.GetMviByName(id);
            return View(Mvi);
        }

        // POST: MovieController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection, Movie pmvi)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    MovieDbRepository.UpdateMvi(pmvi);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MovieController/Delete/5
        public ActionResult Delete(int id)
        {
            if (id <= 0)
            {
                return RedirectToAction("Index");
            }
            Movie Mvi = MovieDbRepository.GetMviByName(id);
            return View(Mvi);
        }

        // POST: MovieController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    MovieDbRepository.DeleteMvi(id);
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
