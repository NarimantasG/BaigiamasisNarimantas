using BaigiamasisDarbas.Drivers;
using BaigiamasisDarbas.Page;
using BaigiamasisDarbas.Tools;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaigiamasisDarbas.Test
{
    class BaseTest
    {
        protected static IWebDriver Driver;
        
        public static BaigiamojoDarboPage _baigiamojoDarboPage;



        [OneTimeSetUp]
        public static void SetUp()
        {
            Driver = CustomDriver.GetChromeDriver();
            
            _baigiamojoDarboPage = new BaigiamojoDarboPage(Driver);
        }
        [TearDown]
        public static void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                MyScreenshot.TakeScreenshot(Driver);
            }
        }
        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {
            Driver.Close();
        }
    }
}