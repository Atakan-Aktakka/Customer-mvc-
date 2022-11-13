using Microsoft.AspNetCore.Mvc;

namespace Webservis_mvc_.Controllers
{
    public class SessionDemoController:Controller
    {
       private string isim = "Atakan";
        public string Index1()
        {
            isim = "Ahmet";
            return isim;
        }
        public string Index2()
        {
            return isim;
        }
    }
}
