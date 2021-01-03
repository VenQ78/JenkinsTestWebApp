using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Web.Mvc;
using JenkinsTestWebApp.Controllers;

namespace JenkinsTestUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Input()
        {
            HomeController test = new HomeController();
            ViewResult result = test.JenkinsTest(103) as ViewResult;
            Assert.IsNotNull(result);


        }
    }
}
