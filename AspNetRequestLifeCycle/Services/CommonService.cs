using System.Diagnostics;

namespace AspNetRequestLifeCycle.Services
{
    public interface ICommonService
    {
    }

    public class CommonService : ICommonService
    {
        public CommonService()
        {
            Debug.WriteLine("CommonService constructor");
        }
    }
}
