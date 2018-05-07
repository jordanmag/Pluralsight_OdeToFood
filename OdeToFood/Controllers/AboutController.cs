using Microsoft.AspNetCore.Mvc;

namespace OdeToFood.Controllers
{
    [Route("company/[controller]/[action]")]
    public class AboutController
    {
        public string Phone()
        {
            return "1800 Hotline Bling";
        }

        public string Address()
        {
            return "Melbourne";
        }
    }
}
