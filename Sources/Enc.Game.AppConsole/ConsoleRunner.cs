using Enc.Game.Manager.Clients;
using Enc.Game.Manager.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enc.Game.AppConsole
{
    internal class ConsoleRunner
    {
        public async Task Run()
        {

            try
            {
                //var encApp = new CommonFunctionality();
                //string response = encApp.LoginPost("dummy_password", "dummy_user");
                //string resp = encApp.LevelManagement("25186");

                var webRequestFactory = new WebRequestsFactory();
                var client = webRequestFactory.Create<CommonFunctionalityClient>();

                await webRequestFactory.Login("dummy_user", "password123456");
                 client = webRequestFactory.Create<CommonFunctionalityClient>();

                string lvlManagementResponse = await client.LevelManagement("25186");
                Console.WriteLine("success");
            }
            catch(Exception exception)
            {
                Console.WriteLine(exception);
            }
            Console.ReadKey();
        }
    }
}
