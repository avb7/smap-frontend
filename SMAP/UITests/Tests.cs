using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using SMAP.Services;
using Xamarin.UITest;
using Xamarin.UITest.Queries;


namespace SMAP.UITests
{
    [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public class Tests
    {
        /*static void Main(string[] args) {
            UserService a = new UserService();
            string email = "sev@ucsd.edu";
            //Console.WriteLine(a.getById(email));
            var b = a.getById(email);
        }*/

        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        public void WelcomeTextIsDisplayed()
        {
            AppResult[] results = app.WaitForElement(c => c.Marked("Welcome to Xamarin Forms!"));
            app.Screenshot("Welcome screen.");

            Assert.IsTrue(results.Any());
        }
    }
}
