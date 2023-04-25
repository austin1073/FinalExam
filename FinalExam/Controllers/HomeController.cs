using FinalExam.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FinalExam.Controllers
{
    public class HomeController : Controller
    {
        private IEntertainerRepository repo;

        public HomeController (IEntertainerRepository temp)
        {
            repo = temp;
        }



        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            var blah = repo.Entertainers.ToList();

            return View(blah);
        }

        [HttpGet]
        public IActionResult AddEntertainer()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddEntertainer(Entertainer temp)
        {
            repo.AddEntertainer(temp);
            return View("Confirmation", temp);
        }

        [HttpGet]
        public IActionResult EntertainerDetails(int id)
        {
            var entertainer = repo.GetEntertainerById(id);
            return View(entertainer);
        }

        [HttpPost]
        public IActionResult DeleteEntertainer(int id)
        {
            repo.DeleteEntertainer(id);
            return RedirectToAction("List");
        }

        [HttpPost]
        public IActionResult EditEntertainer(Entertainer entertainer, int id)
        {
            if (ModelState.IsValid)
            {
                var existingEntertainer = repo.GetEntertainerById(id);

                if (existingEntertainer != null)
                {
                    existingEntertainer.EntStageName = entertainer.EntStageName;
                    existingEntertainer.EntSsn = entertainer.EntSsn;
                    existingEntertainer.EntStreetAddress = entertainer.EntStreetAddress;
                    existingEntertainer.EntCity = entertainer.EntCity;
                    existingEntertainer.EntState = entertainer.EntState;
                    existingEntertainer.EntZipCode = entertainer.EntZipCode;
                    existingEntertainer.EntPhoneNumber = entertainer.EntPhoneNumber;
                    existingEntertainer.EntWebPage = entertainer.EntWebPage;
                    existingEntertainer.EntEmailAddress = entertainer.EntEmailAddress;
                    existingEntertainer.DateEntered = entertainer.DateEntered;

                    repo.UpdateEntertainer(id, existingEntertainer);

                    return RedirectToAction("List");
                }
            }

            return View(entertainer);
        }




    }
}
