using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using Enc.Game.Manager.Clients;
using Enc.Game.Manager.Helpers;

namespace Enc.Game.Manager.Tests.Clients
{
    [TestClass]
    public class CommonFunctionalityClientTest
    {
        private const string SITE_URL = "http://demo.en.cx/";

        private const string USERNAME = "dummy_user";
        private const string PASSWORD = "password123456";

        [TestMethod]
        public void Test_Login()
        {
            var cookieContainer = new CookieContainer();

            var client = new CommonFunctionalityClient(cookieContainer, SITE_URL);
            var task = client.LoginPost(PASSWORD, USERNAME);
            task.Wait();
            var httpClient = task.Result;

            Assert.IsTrue(httpClient.Response.StatusCode == HttpStatusCode.OK);
            var responseCookies = cookieContainer.GetAllCookies();


            var authCookie = responseCookies["atoken"];

            Assert.IsNotNull(authCookie);
        }

        [TestMethod]
        public void Test_LevelManagement()
        {
            const string GAME_ID = "25186";
            var cookieContainer = new CookieContainer();

            var client = new CommonFunctionalityClient(cookieContainer, SITE_URL);
            var taskLogin = client.LoginPost(PASSWORD, USERNAME);
            taskLogin.Wait();
            var task =  client.LevelManagement(GAME_ID);
            task.Wait();
            var httpClient = task.Result;
            string htmlPage = httpClient.GetResponseString();
            Assert.IsTrue(htmlPage.Contains("Level"));

        }

        [TestMethod]
        public void Test_GzipStreamEncoding()
        {
            var cookieContainer = new CookieContainer();

            var client = new CommonFunctionalityClient(cookieContainer, SITE_URL);
            client.UseGzipEncoding = true;
            var task = client.LoginPost(PASSWORD, USERNAME);
            task.Wait();
            var httpClient = task.Result;

            Assert.IsTrue(httpClient.Response.StatusCode == HttpStatusCode.OK);
        }
    }
}
