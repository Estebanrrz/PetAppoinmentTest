using OpenQA.Selenium;

namespace FrameworkPet
{
    public class ListOfAppointmentsPage : BasePage
    {
        public ListOfAppointmentsPage(IWebDriver driver) : base(driver)
        {
        }
       
        #region Locators
        private const string XPATH_PET_NAME = "//p[text() ='Pet: ']/span";
        private const string XPATH_OWNER_NAME = "//p[text() ='Owner: ']/span";
        private const string XPATH_DATE = "//p[text() ='Date: ']/span";
        private const string XPATH_TIME = "//p[text() ='Time: ']/span";
        private const string XPATH_SYMPTOMS = "//p[text() ='Symptoms: ']/span";
        #endregion

        #region Methods
        public Dictionary<string, string> GetFirstAppointmentInformation() 
        {
            Dictionary<string, string> appoinment = new Dictionary<string, string>();
            appoinment.Add("Pet", driver.FindElement(By.XPath(XPATH_PET_NAME)).Text);
            appoinment.Add("Owner", driver.FindElement(By.XPath(XPATH_OWNER_NAME)).Text);
            appoinment.Add("Date", driver.FindElement(By.XPath(XPATH_DATE)).Text);
            appoinment.Add("Time", driver.FindElement(By.XPath(XPATH_TIME)).Text);
            appoinment.Add("Symptoms", driver.FindElement(By.XPath(XPATH_SYMPTOMS)).Text);

            return appoinment;
        }
        #endregion

    }
}
