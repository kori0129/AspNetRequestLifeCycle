using System.Diagnostics;

namespace AspNetRequestLifeCycle.Services
{
    public interface IService2
    {
    }

    public class Service2 : IService2
    {
        public Service2(ICommonService commonService)
        {
            Debug.WriteLine("Service2 constructor");
        }
    }
}
