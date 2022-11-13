using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Webservis_mvc_.Entites;
using Webservis_mvc_.Models;
using Webservis_mvc_.Services.Logging;


namespace Webservis_mvc_.Controllers
{
    [Route(template:"deneme")]
    public class CustomerController:Controller
    {
        private ILogger _logger;

        public CustomerController(ILogger logger)
        {
            _logger = logger;
        }
        //http get
        [Route(template:"index")]
        [Route(template: "")]
        [Route(template: "~/anasayfa")]
        public IActionResult Index3()
        {
           // _logger.Log("");
            /*DatabaseLogger logger = new DatabaseLogger();
            logger.Log("");*/
            List<Customer> customers = new List<Customer>
            {
                new Customer{id=1,FirstName="Engin",LastName="Demiroğ",City="Ankara" },
                new Customer{id=2,FirstName="Engin 2",LastName="Demiroğ",City="Ankara" },
                new Customer{id=3,FirstName="Engin 3",LastName="Demiroğ",City="Ankara" },
            };
            List<string> shops = new List<string> { "Ankara", "İstanbul", "İzmir" };
            var model = new CustomerListViewModel
            {
                Customers = customers,
                Shops = shops
            };
            return View(model);
        }
        [HttpGet]
        [Route(template:"save")]
        public IActionResult SaveCustomer()
        {
            return View(new SaveCustomerViewModel
            {
                Cities=new List<SelectListItem>
                {
                    new SelectListItem{Text="Ankara",Value="06"},
                    new SelectListItem{Text="İzmir",Value="35"},
                    new SelectListItem{Text="İstanbul",Value="34"}
                }

            });
        }
        [HttpPost]
        [Route(template: "save")]
        public string SaveCustomer(Customer customer)
        {
            return "Kaydedildi";
        }
    }
}
