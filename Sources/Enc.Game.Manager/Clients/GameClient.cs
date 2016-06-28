using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Enc.Game.Manager.Clients
{
    public class GameClient
    {
        public GameClient(CookieContainer cookies, string appUrl)
        {
            this.AppUrl = appUrl;
            this.Cookies = cookies;
        }

        public string AppUrl { get; private set; }
        internal CookieContainer Cookies { get; private set; }
        //protected virtual void SetCookies(CookieContainer cookies)
        //{
        //    this.Cookies = cookies;
        //}

        public HttpWebRequest Request {get;set;}
    }
}
