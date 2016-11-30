using Microsoft.AspNetCore.Mvc;
using WebModular.ModuleA.Common;

namespace WebModular.ModuleA.Web.Controllers
{
    public class TestController : Controller    
    {
        private readonly ITestService _testService;

        public TestController(ITestService testService)
        {
            _testService = testService;
        }

        public IActionResult Index()
        {
            return View("Index", _testService.GetList());
        }
    }
}
