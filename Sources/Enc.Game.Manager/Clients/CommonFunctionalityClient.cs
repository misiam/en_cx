using Enc.Game.Manager.Helpers;
using Enc.Game.Manager.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Enc.Game.Manager.Clients
{
    public class CommonFunctionalityClient : GameClient
    {
        private bool _runAsync = false;

        public CommonFunctionalityClient(CookieContainer cookies, string appUrl = "http://demo.en.cx/") : base(cookies, appUrl)
        {
            this.UseGzipEncoding = true;
        }

        /// <summary>
        /// Cookies and the following properties are set:
        /// <list type="number">
        ///  <item><description>Accept</description></item>
        ///  <item><description>Headers["Cache-Control"]</description></item>
        ///  <item><description>Headers["Upgrade-Insecure-Requests"]</description></item>
        ///  <item><description>Headers["Accept-Encoding"]</description></item>
        ///  <item><description>Headers["Accept-Language"]</description></item>
        /// </list>
        /// </summary>
        /// <param name="url">Request URI string</param>
        /// <param name="httpMethod">HTTP method for the request</param>
        /// <returns></returns>
        private HttpWebRequest SetupRequest(string url, string httpMethod)
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.Method = httpMethod;

            req.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
            req.Headers["Cache-Control"] = "max-age=0";
            req.Headers["Upgrade-Insecure-Requests"] = "1";
            req.Headers["Accept-Language"] = "ru-RU,ru;q=0.8,en-US;q=0.6,en;q=0.4";
            if (this.UseGzipEncoding)
            {
                req.Headers["Accept-Encoding"] = "gzip, deflate";
            }

            req.CookieContainer = this.Cookies;
            return req;
        }

        public async Task<IHttpClientContainer> LoginPost(string password, string username)
        {
            string url = this.AppUrl + "Login.aspx" + "?return=/Default.aspx";
            var req = this.SetupRequest(url, "POST");
            req.Headers["Origin"] = "http://demo.en.cx";
            req.ContentType = "application/x-www-form-urlencoded";

            IHttpClientDecorator httpClient = new HttpClientDecorator(req, this.UseGzipEncoding);
            string postData = "ddlNetwork=1&EnButton1=Р’С…РѕРґ&socialAssign=0&Login=" + username + "&Password=" + password + "";

            await httpClient.SendHttpRequest(postData);
            await httpClient.GetHttpResponse();

            string response = httpClient.GetResponseString();
            int responseCode = (int)httpClient.Response.StatusCode;

            return httpClient;
        }

        public async Task<IHttpClientContainer> LevelManagement(string gameId)
        {
            //http://demo.en.cx/Administration/Games/LevelManager.aspx?gid=25186
            string url = "http://demo.en.cx/Administration/Games/LevelManager.aspx" + "?gid=" + gameId + "";
            HttpWebRequest req = this.SetupRequest(url, "GET");

            var httpClient = new HttpClientDecorator(req, this.UseGzipEncoding);
            await httpClient.GetHttpResponse();
            string response = httpClient.GetResponseString();
            int responseCode = (int)httpClient.Response.StatusCode;

            return httpClient;
        }
    }
}