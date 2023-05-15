using OpenQA.Selenium;

namespace FrameworkPet
{
    public class BasePage
    {
        protected IWebDriver driver;

        public BasePage(IWebDriver driver) 
        { 
        this.driver = driver;
        }
    }
}