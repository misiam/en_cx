using Enc.Game.Manager.Clients;
using Enc.Game.Manager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Enc.Game.Manager.Requests
{
    public class WebRequestsFactory
    {
        public WebRequestsFactory(string appUrl = "http://demo.en.cx/")
        {
            this.AppUrl = appUrl;
        }

        public string AppUrl { get; private set; }
        public CookieContainer Cookies { get; set; } = new CookieContainer();

        public T Create<T>() where T : GameClient
        {
            var clientInstance = (T)Activator.CreateInstance(typeof(T), new object[] {this.Cookies, this.AppUrl});
            return clientInstance;
        }

        public async Task Login(string user, string password)
        {
            var commonFuncClient = this.Create<CommonFunctionalityClient>();
            IHttpClientContainer httpClient = await commonFuncClient.LoginPost(password, user);
            HttpWebResponse response = httpClient.Response;
        }

        public HttpWebRequest Create(string requestParameters="")
        {
            HttpClientHandler clientHandler = new HttpClientHandler();
            System.Net.Http.HttpClient client = new HttpClient(clientHandler);

            string url = this.AppUrl + requestParameters;
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);

            return req;
        }
    }
}
