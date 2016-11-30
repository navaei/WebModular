using System.Collections.Generic;

namespace WebModular.ModuleA.Common
{
    public interface ITestService
    {
        IList<TestModel> GetList(); 
        string Get();        
    }
}
