using Microsoft.AspNetCore.Mvc.Rendering;
using Webservis_mvc_.Entites;

namespace Webservis_mvc_.Models
{
    public class SaveCustomerViewModel
    {
        public Customer Customer { get; set; } 
        public List<SelectListItem> Cities { get; set; }
    }
}
