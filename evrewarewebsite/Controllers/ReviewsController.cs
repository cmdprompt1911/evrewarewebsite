using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;
//using Dimmi.Models.UI;

namespace evrewarewebsite.Controllers
{
    public class ReviewsController : Controller
    {
        HttpClient client = null;
        public ReviewsController()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost/dimmimdb/");

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

        }

        //
        // GET: /Reviews/

        public ActionResult SearchReviews()
        {
            return View();
        }

        public String Search(string searchText)
        {
            HttpResponseMessage response = client.GetAsync("api/reviewables").Result;  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                //// Parse the response body. Blocking!
                //var reviewables = response.Content.ReadAsAsync<IEnumerable<Reviewable>>().Result;
                return ""; // response.Content; // reviewables;
            }
            else
            {
                return "error";
            }

            //ViewBag.Message = "Hello World";
            //return "Hello World";
        }

    }
}
