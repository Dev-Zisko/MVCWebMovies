﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebtestMVC.Controllers
{
    public class HellowWorldController : Controller
    {
        // GET: HellowWorldController
        public ActionResult Index()
        {
            return View();
        }

        // GET: HellowWorldController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HellowWorldController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HellowWorldController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HellowWorldController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HellowWorldController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HellowWorldController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HellowWorldController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
