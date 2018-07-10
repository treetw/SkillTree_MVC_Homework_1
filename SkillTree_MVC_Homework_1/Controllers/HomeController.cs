using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SkillTree_MVC_Homework_1.Models.ViewModels;

namespace SkillTree_MVC_Homework_1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var list = new List<DetailsViewModel>
            {
                new DetailsViewModel {Category = "收入", Date = new DateTime(2018,6,1), Amount = 20000},
                new DetailsViewModel {Category = "支出", Date = new DateTime(2018,6,1), Amount = 100},
                new DetailsViewModel {Category = "支出", Date = new DateTime(2018,6,2), Amount = 50},
                new DetailsViewModel {Category = "支出", Date = new DateTime(2018,6,2), Amount = 1000},
                new DetailsViewModel {Category = "支出", Date = new DateTime(2018,6,2), Amount = 20},
                new DetailsViewModel {Category = "支出", Date = new DateTime(2018,6,3), Amount = 10},
                new DetailsViewModel {Category = "支出", Date = new DateTime(2018,6,3), Amount = 200},
                new DetailsViewModel {Category = "支出", Date = new DateTime(2018,6,3), Amount = 50},
                new DetailsViewModel {Category = "支出", Date = new DateTime(2018,6,4), Amount = 100},
                new DetailsViewModel {Category = "支出", Date = new DateTime(2018,6,4), Amount = 30},
                new DetailsViewModel {Category = "支出", Date = new DateTime(2018,6,4), Amount = 10},
                new DetailsViewModel {Category = "支出", Date = new DateTime(2018,6,4), Amount = 20},
                new DetailsViewModel {Category = "支出", Date = new DateTime(2018,6,4), Amount = 3500},
                new DetailsViewModel {Category = "支出", Date = new DateTime(2018,6,5), Amount = 140},
                new DetailsViewModel {Category = "支出", Date = new DateTime(2018,6,5), Amount = 12},
                new DetailsViewModel {Category = "支出", Date = new DateTime(2018,6,6), Amount = 600},
                new DetailsViewModel {Category = "支出", Date = new DateTime(2018,6,7), Amount = 250},
                new DetailsViewModel {Category = "支出", Date = new DateTime(2018,6,8), Amount = 500},
                new DetailsViewModel {Category = "支出", Date = new DateTime(2018,6,9), Amount = 1500},
                new DetailsViewModel {Category = "支出", Date = new DateTime(2018,6,9), Amount = 10},
                new DetailsViewModel {Category = "支出", Date = new DateTime(2018,6,10), Amount = 40},
                new DetailsViewModel {Category = "支出", Date = new DateTime(2018,6,10), Amount = 600},
                new DetailsViewModel {Category = "支出", Date = new DateTime(2018,6,11), Amount = 300},
                new DetailsViewModel {Category = "支出", Date = new DateTime(2018,6,12), Amount = 10},
                new DetailsViewModel {Category = "支出", Date = new DateTime(2018,6,13), Amount = 100},
                new DetailsViewModel {Category = "支出", Date = new DateTime(2018,6,14), Amount = 200},
                new DetailsViewModel {Category = "支出", Date = new DateTime(2018,6,15), Amount = 600},
                new DetailsViewModel {Category = "支出", Date = new DateTime(2018,6,17), Amount = 1000},
                new DetailsViewModel {Category = "支出", Date = new DateTime(2018,6,18), Amount = 850},
                new DetailsViewModel {Category = "支出", Date = new DateTime(2018,6,19), Amount = 60},
                new DetailsViewModel {Category = "支出", Date = new DateTime(2018,6,20), Amount = 90},
                new DetailsViewModel {Category = "支出", Date = new DateTime(2018,6,20), Amount = 120},
                new DetailsViewModel {Category = "支出", Date = new DateTime(2018,6,21), Amount = 300},
                new DetailsViewModel {Category = "支出", Date = new DateTime(2018,6,22), Amount = 500},
                new DetailsViewModel {Category = "支出", Date = new DateTime(2018,6,23), Amount = 8500},
                new DetailsViewModel {Category = "支出", Date = new DateTime(2018,6,24), Amount = 520},
                new DetailsViewModel {Category = "支出", Date = new DateTime(2018,6,25), Amount = 120},
                new DetailsViewModel {Category = "支出", Date = new DateTime(2018,6,25), Amount = 600},
                new DetailsViewModel {Category = "支出", Date = new DateTime(2018,6,27), Amount = 140},
                new DetailsViewModel {Category = "支出", Date = new DateTime(2018,6,28), Amount = 920},
                new DetailsViewModel {Category = "支出", Date = new DateTime(2018,6,29), Amount = 100},
                new DetailsViewModel {Category = "支出", Date = new DateTime(2018,6,30), Amount = 600},
                new DetailsViewModel {Category = "支出", Date = new DateTime(2018,7,1), Amount = 20000},
                new DetailsViewModel {Category = "支出", Date = new DateTime(2018,7,2), Amount = 100},
                new DetailsViewModel {Category = "支出", Date = new DateTime(2018,7,2), Amount = 200},
                new DetailsViewModel {Category = "支出", Date = new DateTime(2018,7,3), Amount = 960},
                new DetailsViewModel {Category = "支出", Date = new DateTime(2018,7,4), Amount = 75},
                new DetailsViewModel {Category = "支出", Date = new DateTime(2018,7,5), Amount = 32},
                new DetailsViewModel {Category = "支出", Date = new DateTime(2018,7,6), Amount = 18},
                new DetailsViewModel {Category = "支出", Date = new DateTime(2018,7,7), Amount = 62}
            };
            return View(list);
        }
        
    }
}
