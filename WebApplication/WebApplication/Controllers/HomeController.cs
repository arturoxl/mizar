using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.Models;
using System.Data.Entity;
using Entity.Model;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {           
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [ActionName("AccessConfiguration")]       
        public ActionResult ConfigurationUsingGet()
        {
            Debug.WriteLine("Executing the GET Method for AccessConfiguration-actionResult");
            ViewBag.Message = "You are accesing to your configuration page.";
            return View();
        }

        [HttpPost]
        [ActionName("AccessConfiguration")]
        public ActionResult ConfigurationUsingPost(ActorViewModel actorModel)
        {
            Debug.WriteLine("Executing the POST Method AccessConfiguration-actionResult");
            ViewBag.Message = "You are just using the post method.";
            if (ModelState.IsValid)
            {
                using (var innerContext = new TheaterContext())
                {

                    var actor = new Actor()
                    {
                        name = actorModel.name,
                        lastname = actorModel.lastname,
                        age = actorModel.age
                    };

                    var film = new Film()
                    {
                        nameFilm = "last opportunity",
                        producer = "guy ritchie",
                        year = 2030
                    };

                    var director = new Entity.Model.Director()
                    {
                        nameDirector = "alfonso cuaron",
                        nacionality = "mexican"
                    };


                    innerContext.Actor.Add(actor);
                    innerContext.Film.Add(film);
                    innerContext.Director.Add(director);
                    innerContext.SaveChanges();
                 
                    Debug.WriteLine("Name: " + actorModel.name);
                    Debug.WriteLine("Lastanem: " + actorModel.lastname);
                    Debug.WriteLine("Age: " + actorModel.age);

                    return RedirectToAction("Resume");
                }
               
            }

            return View(actorModel);
        }

        [HttpGet]
        [ActionName("Resume")]
        public ActionResult getAllActors()
        {
            var innerContext = new TheaterContext();
            return View(innerContext.Actor);
        }
            
    }
}