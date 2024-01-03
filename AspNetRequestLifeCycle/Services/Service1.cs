using System.Diagnostics;

namespace AspNetRequestLifeCycle.Services
{
    public interface IService1
    {
    }

    public class Service1 : IService1
    {
        public Service1(ICommonService commonService)
        {
            Debug.WriteLine("Service1 constructor");
        }
    }
}
