using dropdownmvc.Models.Data;
using Microsoft.AspNetCore.Mvc;

namespace dropdownmvc.Controllers
{
    public class CascadeController : Controller
    {
        private readonly ApplicationContect context;
         
        public CascadeController(ApplicationContect context) 
        {
            this.context = context;
        }
        public JsonResult Country()
        {
            var cnt=context.countries.ToList();
            return new JsonResult(cnt);

        }
        public JsonResult State(int? id)
        {
            var st=context.states.Where(e =>e.Country.Id == id).ToList();
            return new JsonResult(st);
        }
        public JsonResult City(int? id)
        {
            var ct=context.citys.Where(e => e.State.Id == id).ToList();
            return new JsonResult(ct);
        }

        public ActionResult CascadeDropdown()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
