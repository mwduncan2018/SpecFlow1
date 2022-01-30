using OpenQA.Selenium;
using SpecFlowBdd.Config;


namespace SpecFlowBdd.PageModels
{
    public class Pages
    {
        public void OpenApp()
        {
            var app = new AppSettingsProvider();
            if (app.GetSetting().Environment == "local")
                Driver.Navigate().GoToUrl(new AppSettingsProvider().GetSetting().LocalUrl);
            if (app.GetSetting().Environment == "remote")
                Driver.Navigate().GoToUrl(new AppSettingsProvider().GetSetting().RemoteUrl);
        }

        public IWebDriver Driver;
        public NavbarPage NavbarPage;
        public ContactPage ContactPage;
        public ProductListPage ProductListPage;
        public ProductAddPage ProductAddPage;
        public ProductEditPage ProductEditPage;
        public ProductDetailsPage ProductDetailsPage;
        public ProductDeletePage ProductDeletePage;
        public WatchListPage WatchListPage;
        public WatchListAddPage WatchListAddPage;
        public WatchListEditPage WatchListEditPage;
        public WatchListDetailsPage WatchListDetailsPage;
        public WatchListDeletePage WatchListDeletePage;

        public Pages(IWebDriver driver)
        {
            Driver = driver;
            NavbarPage = new NavbarPage(Driver);
            ContactPage = new ContactPage(Driver);
            ProductListPage = new ProductListPage(Driver);
            ProductAddPage = new ProductAddPage(Driver);
            ProductEditPage = new ProductEditPage(Driver);
            ProductDetailsPage = new ProductDetailsPage(Driver);
            ProductDeletePage = new ProductDeletePage(Driver);
            WatchListPage = new WatchListPage(Driver);
            WatchListAddPage = new WatchListAddPage(Driver);
            WatchListEditPage = new WatchListEditPage(Driver);
            WatchListDetailsPage = new WatchListDetailsPage(Driver);
            WatchListDeletePage = new WatchListDeletePage(Driver);
        }
    }
}
