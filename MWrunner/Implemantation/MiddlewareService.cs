using MWrunner.model;
using MWrunner.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MWrunner.Implemantation
{
    public class MiddlewareService : IMiddlewareService
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

        public string LocationDetection()
        {
           string Cwd  = Directory.GetCurrentDirectory();
            string MiddlewareProjectDirectory = "incadea.API Middleware";
            string fullpath = Path.Combine(Cwd, MiddlewareProjectDirectory);
            Console.WriteLine("Checking For Middleware Project\n");
            if(Directory.Exists(fullpath))
            {
                Console.WriteLine("Middleware Project Found Successfully\n");
                return fullpath;
            }
            else
            {
                Console.WriteLine("Middleware Project Not Found. :(\n");
                return null;
            }
            
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
