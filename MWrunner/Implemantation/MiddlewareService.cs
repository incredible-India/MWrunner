using MWrunner.model;
using MWrunner.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MWrunner.Implemantation
{
    internal class MiddlewareService : IMiddlewareService
    {
        public bool AllFileFound()
        {
            throw new NotImplementedException();
        }

        public Info AskingCredentials()
        {
            Info info = new Info();
            Console.WriteLine( "Enter Postgres Password..\t");
            info.PostgresPassword = Console.ReadLine();

            return info;
        }

        public bool LocationDetection()
        {
            throw new NotImplementedException();
        }

        public bool ModificationAdmin()
        {
            throw new NotImplementedException();
        }

        public bool ModificationWeb()
        {
            throw new NotImplementedException();
        }

        public bool Running()
        {
            throw new NotImplementedException();
        }
    }
}
