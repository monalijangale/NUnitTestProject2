using BoDi;
using NUnitTestProject2.Util;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace NUnitTestProject2.steps
{

    [Binding]
    class BaseStep
    {
        private static IWebDriver driver;
        private string browser;
        private object capability;
        private readonly IObjectContainer objectContainer;

        public BaseStep(IObjectContainer container)
        {
            objectContainer = container;
        }
        [BeforeScenario("web")]
        public void createDriver()
        {
            string path = common.GetConfig("browser_executables");
            string Browser = common.GetConfig("browser");
           
            
            // driver = new ChromeDriver(@path);
            // driver=new InternetExplorerDriver(@path);
            if (common.GetConfig("Mode") == "local")
            {
                switch (Browser)
                {
                    case "chrome":
                        driver = new ChromeDriver(@path);
                        break;

                    case "IE":


                        driver = new InternetExplorerDriver(@path); ;
                        break;



                }
            }
            else
            {
                DesiredCapabilities capability = new DesiredCapabilities();

                capability.SetCapability("os_version", common.GetConfig("os_version"));
                capability.SetCapability("browser", common.GetConfig("browser"));
                capability.SetCapability("browser_version", common.GetConfig("browser_version"));
                capability.SetCapability("browserstack.local", common.GetConfig("browserstack.local"));
                capability.SetCapability("browserstack.selenium_version", common.GetConfig("browserstack.selenium_version"));
                capability.SetCapability("browserstack.user", common.GetConfig("browserstack.user"));
                capability.SetCapability("browserstack.key", common.GetConfig("browserstack.key"));
                RemoteWebDriver _driver = new RemoteWebDriver(new Uri(common.GetConfig("Uri")), capability);
                driver = _driver;
            }
            objectContainer.RegisterInstanceAs<IWebDriver>(driver);


        }

        [AfterScenario("web")]
        public void closebrowser()
        {
            driver.Close();
            driver.Quit();
        }
    }
}
