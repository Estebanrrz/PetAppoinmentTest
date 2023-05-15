using OpenQA.Selenium;

namespace FrameworkPet
{
    public class CreateAppointmentPage : BasePage
    {
        public CreateAppointmentPage(IWebDriver driver) : base(driver)
        {
        }

        #region Locators
        private const string XPATH_PET_NAME_INPUT = "//input[@data-testid ='pet']";
        private const string XPATH_OWNER_NAME_INPUT = "//input[@data-testid ='owner']";
        private const string XPATH_DATE_INPUT = "//input[@data-testid ='date']";
        private const string XPATH_TIME_NAME_INPUT = "//input[@data-testid ='time']";
        private const string XPATH_SYMPTOMS_INPUT = "//textarea[@data-testid ='symptoms']";
        private const string XPATH_ADD_APPOINTMENT_BUTTON = "//button[@data-testid ='btn-submit']";
        #endregion
        #region Methods
        public void TypePetName(string petName) => driver.FindElement(By.XPath(XPATH_PET_NAME_INPUT)).SendKeys(petName);
        public void TypeOwnerName(string ownerName) => driver.FindElement(By.XPath(XPATH_OWNER_NAME_INPUT)).SendKeys(ownerName);
        public void TypeDate(string date) => driver.FindElement(By.XPath(XPATH_DATE_INPUT)).SendKeys(date);
        public void TypeTime(string time) => driver.FindElement(By.XPath(XPATH_TIME_NAME_INPUT)).SendKeys(time);
        public void TypeSymptoms(string symptoms) => driver.FindElement(By.XPath(XPATH_SYMPTOMS_INPUT)).SendKeys(symptoms);
        public void ClickAddAppoinment()=> driver.FindElement(By.XPath(XPATH_ADD_APPOINTMENT_BUTTON)).Click();
        #endregion

    }
}
