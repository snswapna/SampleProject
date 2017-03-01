using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SampleProject.Models;
using SampleProject.ViewModels;
using Newtonsoft.Json;
//using System.Web.Http;
using System.Net.Http;
using System.Threading.Tasks;

namespace SampleProject.Controllers
{
    public class ProductsController : Controller
    {
        HttpClient client;
        string producstUrl = "http://localhost:56230/api/products";
        string statesUrl = "http://localhost:56230/api/states";


        // GET: Products/ProductsList
        //private ApplicationDbContext _dbcontext;

        public ProductsController()
        {
            client = new HttpClient();

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

        }

        //protected override void Dispose(bool disposing)
        //{
        //    _dbcontext.Dispose();
        //}
        public async Task<ActionResult> Products()
        {


            client.BaseAddress = new Uri(producstUrl);

            HttpResponseMessage responseMsg = await client.GetAsync(producstUrl);
            if (responseMsg.IsSuccessStatusCode)
            {
                var responseData = responseMsg.Content.ReadAsStringAsync().Result;
                var products = JsonConvert.DeserializeObject<List<Products>>(responseData);




                //client.BaseAddress = Uri(statesUrl);
                HttpResponseMessage responseMsg1 = await client.GetAsync(statesUrl);
                if (responseMsg1.IsSuccessStatusCode)
                {
                    var responseData1 = responseMsg1.Content.ReadAsStringAsync().Result;
                    var states = JsonConvert.DeserializeObject<List<States>>(responseData1);

                    var viewModel = new ProductViewModel { Products = products, States = states };
                    return View(viewModel);

                }
            }







            return View("Error");
        }

        public async Task<ActionResult> States()
        {

            client.BaseAddress = new Uri(statesUrl);
            HttpResponseMessage responseMsg = await client.GetAsync(statesUrl);
            if (responseMsg.IsSuccessStatusCode)
            {
                var responseData = responseMsg.Content.ReadAsStringAsync().Result;
                var states = JsonConvert.DeserializeObject<List<States>>(responseData);

                var viewModel = new ProductViewModel { States = states };
                return View(viewModel);

            }




            return View("Error");
        }



        //[Route("products/productdetails/{quantity}/{price}")]
        //public ActionResult ProductDetails(int id)
        //{

        //    var product = _dbcontext.Products.SingleOrDefault(c => c.Id == id);
        //    return View(product);

        //}

        //public ActionResult AddToCart(ProductViewModel vModel, int id)
        //{
        //   ProductViewModel


        //}

        //[HttpPost]
        //public ActionResult Thanks(ProductViewModel procViewModel,  FormCollection formcol)
        //{

        //    var tax = formcol["txtTax"];
        //    Checkout model = new Checkout();
        //    foreach (Products proc in procViewModel.Products)
        //    {
        //        int quantity = proc.Quantity;
        //    }
       
        //    return View();
        //}
    }
}