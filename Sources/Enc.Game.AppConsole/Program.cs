using Enc.Game.Manager.Clients;
using Enc.Game.Manager.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enc.Game.AppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                ConsoleRunner runner = new ConsoleRunner();
                var task = runner.Run();
            }
            catch(Exception exception)
            {
                Console.WriteLine(exception);
            }
            Console.ReadKey();
        }
    }
}
