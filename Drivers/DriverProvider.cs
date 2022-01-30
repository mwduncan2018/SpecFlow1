using System;
using System.Drawing;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using SpecFlowBdd.Config;

namespace SpecFlowBdd.Drivers
{
    public class DriverProvider
    {
        TimeSpan _implicitWait;
        Size _windowSize;
        string _environment;
        string _driverType;
        bool _maximize;
        string _gridIp;

        public DriverProvider()
        {
            AppSettingsProvider asp = new AppSettingsProvider();
            _environment = asp.GetSetting().Environment;
            _driverType = asp.GetSetting().DriverType;
            _maximize = asp.GetSetting().Maximize;
            _implicitWait = TimeSpan.FromSeconds(asp.GetSetting().ImplicitWait);
            _windowSize = new Size(
                asp.GetSetting().HorizontalPixels,
                asp.GetSetting().VerticalPixels);
            _gridIp = asp.GetSetting().GridIp;
            //_gridIp = Environment.GetEnvironmentVariable("GRID_IP") == null ? Environment.GetEnvironmentVariable("GRID_IP") : asp.GetSetting().GridIp;
        }

        public IWebDriver GetDriver()
        {
            IWebDriver? driver = (_environment == "remote") ? GetRemoteDriver() : GetLocalDriver();
            driver.Manage().Timeouts().ImplicitWait = _implicitWait;
            driver.Manage().Window.Size = _windowSize;
            if (_maximize)
                driver.Manage().Window.Maximize();
            return driver;
        }

        private IWebDriver? GetRemoteDriver()
        {
            if (_driverType == "random")
            {
                int random = new Random().Next(1, 4);
                if (random == 1)
                {
                    FirefoxOptions options = new FirefoxOptions();
                    return new RemoteWebDriver(new Uri(_gridIp), options.ToCapabilities(), TimeSpan.FromMinutes(30));
                }
                if (random == 2)
                {
                    ChromeOptions options = new ChromeOptions();
                    return new RemoteWebDriver(new Uri(_gridIp), options.ToCapabilities(), TimeSpan.FromMinutes(30));
                }
                if (random == 3)
                {
                    EdgeOptions options = new EdgeOptions();
                    return new RemoteWebDriver(new Uri(_gridIp), options.ToCapabilities(), TimeSpan.FromMinutes(30));
                }
                return null;
            }
            if (_driverType == "firefox")
            {
                FirefoxOptions options = new FirefoxOptions();
                return new RemoteWebDriver(new Uri(_gridIp), options.ToCapabilities(), TimeSpan.FromMinutes(30));
            }
            if (_driverType == "chrome")
            {
                ChromeOptions options = new ChromeOptions();
                return new RemoteWebDriver(new Uri(_gridIp), options.ToCapabilities(), TimeSpan.FromMinutes(30));
                //return new RemoteWebDriver(new Uri(_gridIp), options);
            }
            if (_driverType == "edge")
            {
                EdgeOptions options = new EdgeOptions();
                return new RemoteWebDriver(new Uri(_gridIp), options.ToCapabilities(), TimeSpan.FromMinutes(30));
            }
            return null;
        }

        private IWebDriver? GetLocalDriver()
        {
            if (_driverType == "firefox")
                return new FirefoxDriver();
            if (_driverType == "chrome")
                return new ChromeDriver();
            if (_driverType == "edge")
                return new EdgeDriver();
            return null;
        }

    }
}
