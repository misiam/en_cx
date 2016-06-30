using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using Enc.Game.Manager.Helpers;

namespace Enc.Game.Manager.Tests.Helpers
{
    [TestClass]
    public class CookiesHelperTest
    {
        private const string SITE_URL = "http://demo.en.cx/";

        [TestMethod]
        public void Test_GetCookieFromContainer()
        {
            CookieContainer cookieContainer = new CookieContainer();
            const string cookieName = "stub";
            const string cookieValue = "stub value";
            var cookieStub = new Cookie(cookieName,cookieValue);
            cookieContainer.Add(new Uri(SITE_URL),cookieStub);

            var cookiesCollection = CookiesHelper.GetAllCookies(cookieContainer);

            var cookieFromHelper = cookiesCollection[cookieName];
            Assert.IsTrue(cookieFromHelper.Name == cookieName && cookieFromHelper.Value == cookieValue);
        }
    }
}
