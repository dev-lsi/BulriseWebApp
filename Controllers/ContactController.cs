using Microsoft.AspNetCore.Mvc;

namespace Bulrise_1._0.Controllers
{
    public class ContactController:Controller
    {
        public IActionResult ContactForm() 
        {
        return View();
        }

    }
}
