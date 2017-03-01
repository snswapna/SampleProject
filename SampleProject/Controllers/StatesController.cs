using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SampleProject.Models;
using SampleProject.ViewModels;
using Newtonsoft.Json;
using System.Web.Http;
using System.Net.Http;
using System.Threading.Tasks;
namespace SampleProject.Controllers
{
    public class StatesController : Controller
    {

        HttpClient client;
        string url = "http://localhost:56230/api/states";


        public StatesController()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(url);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

        }
        // GET: States
        public async Task<ActionResult> States()
        {

            HttpResponseMessage responseMsg = await client.GetAsync(url);
            if (responseMsg.IsSuccessStatusCode)
            {
                var responseData = responseMsg.Content.ReadAsStringAsync().Result;
                var states = JsonConvert.DeserializeObject<List<States>>(responseData);

                var viewModel = new ProductViewModel { States = states };
                return View(viewModel);

            }




            return View("Error");
        }
    }
}