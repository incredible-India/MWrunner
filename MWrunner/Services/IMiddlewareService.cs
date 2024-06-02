using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MWrunner.Services
{
    public interface IMiddlewareService
    {
        public void AskingCredentials();

        public bool LocationDetection();

        public bool AllFileFound();


        public bool ModificationAdmin();

        public bool ModificationWeb();

        public bool Running();



    }
}
