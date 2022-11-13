using Webservis_mvc_.Entites;

namespace Webservis_mvc_.Models
{
    public class CustomerListViewModel
    {
        public List<Customer> Customers { get; set; }
        public List<string> Shops { get; set; }
    }
}
