using System.Collections.Generic;
using WebModular.ModuleA.Common;

namespace WebModular.ModuleA.Service
{
    public class TestService : ITestService
    {
        public IList<TestModel> GetList()
        {
            return new List<TestModel>
            {
                new TestModel {Id = 1, Name = "Test"},
                new TestModel {Id = 2, Name = "Test 2"}
            };
        }

        public string Get()
        {
            return "Testttttt";
        }
    }
}
