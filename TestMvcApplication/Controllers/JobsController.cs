using Newtonsoft.Json;
using System.Net;
using System.Web.Mvc;
using TestMvcApplication.Models;

namespace TestMvcApplication.Controllers
{
    public class JobsController : Controller
    {
        //
        // GET: /Jobs/

        public ActionResult Index()
        {
            return View();
        }

        /*public string Index()
        {
            return "This is my <b>default</b> action...";
        }*/

        // 
        // GET: /Jobs/Welcome/ 
        
        public ActionResult Welcome()
        {
            var json = "";
            var url = "https://gist.githubusercontent.com/WillemLabu/34cfb50187ec334c48ee/raw/cb46400505afd82d9e354b591ad71d97f07613be/jobs.json";

            using (WebClient wc = new WebClient())
            {
                json = wc.DownloadString(url);
            }

            string jsonFixed = json.Replace("-", "");
            var jobsList = JsonConvert.DeserializeObject<RootObject>(jsonFixed);
            
            return View(jobsList);
        }
    }
}
