using MWrunner.model;
using MWrunner.Services;

namespace MWrunner
{
    public class Program
    {
        private    readonly IMiddlewareService _middlewareService;

        public   Program(IMiddlewareService middlewareService)
        {
            _middlewareService = middlewareService;
        }
         void Main(string[] args)
        {
           Info info = new Info();
            info = _middlewareService.AskingCredentials();
            var MiddlewareProjectPath = _middlewareService.LocationDetection();


        }
    }
}