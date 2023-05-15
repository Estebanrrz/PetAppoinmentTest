using FrameworkPet;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AppointmentPet
{
    [TestClass]
    public class AppoinmentTests
    {
        IWebDriver driver;

        [TestInitialize]
        public void SetupInit()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:3000/");
        }

        [TestMethod]
        public void GivenListOfAppoinmentsIsEmpty_AddAnAppointment_InformationAppointmentCorrect()
        {
            // Arrange
            string petName = "Chester";
            string ownerName = "Esteban";
            string symtomps = "Fever, donot eat";
            string time = "10:15AM";
            string date ="05142023";

            // Act
            CreateAppointmentPage createAppointmentPage = new CreateAppointmentPage(driver);
            createAppointmentPage.TypePetName(petName);
            createAppointmentPage.TypeOwnerName(ownerName);
            createAppointmentPage.TypeDate(date);   
            createAppointmentPage.TypeTime(time); 
            createAppointmentPage.TypeSymptoms(symtomps);
            createAppointmentPage.ClickAddAppoinment();

            ListOfAppointmentsPage listOfAppointmentsPage = new ListOfAppointmentsPage(driver);
            Dictionary<string,string> appointment= listOfAppointmentsPage.GetFirstAppointmentInformation();

            // Assert
            Assert.AreEqual(petName, appointment["Pet"],"Pet name is not the expected");
            Assert.AreEqual(ownerName, appointment["Owner"], "Owner name is not the expected");
            Assert.AreEqual("2023-05-14", appointment["Date"], "Date is not the expected");
            Assert.AreEqual("10:15", appointment["Time"], "Pet name is not the expected");
            Assert.AreEqual(symtomps, appointment["Symptoms"], "Pet name is not the expected");

        }


        [TestCleanup]
        public void TestCleanup()
        {
            driver?.Close();
        }
    }
}