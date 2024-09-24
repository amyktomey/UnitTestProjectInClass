using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UnitTestProjectIC
{
    [TestClass]
    public class UnitTest1
    {
        public IWebDriver _webDriver;
        public ApplyPage _applyPage;
        public SeleniumHelpers _seleniumHelpers;

        [TestInitialize]
        public void Setup()
        {
            _webDriver = new ChromeDriver();
            _applyPage = new ApplyPage(_webDriver);
            _seleniumHelpers = new SeleniumHelpers(_webDriver);
        }
        [TestMethod]
        public void TestMethod1()
        {
             _webDriver.Navigate().GoToUrl(_applyPage.applyPageUrl);
             _applyPage.emailTextBox.SendKeys("email@test.com");
             _applyPage.firstNameTextBox.SendKeys("TestFirst");
             _applyPage.lastNameTextBox.SendKeys("TestLast");
             _applyPage.preferrredNameTextBox.SendKeys("TestPreferred ");
             _applyPage.phoneNumberTextBox.SendKeys("555-123-9870");
             _applyPage.birthdayTextBox.SendKeys("01/01/2000");
             _applyPage.streetAddressTextBox.SendKeys("613 Elm Street");
             _applyPage.cityTextBox.SendKeys("Newburg");
             _applyPage.stateDropdown.SelectTextFromDropdown("KY");
             _applyPage.zipCodeTextBox.SendKeys("40218");
             _applyPage.countyDropdown.SelectValueFromDropdown( "Jefferson");
             _applyPage.genderDropdown.SelectIndexFromDropdown(2);
             _applyPage.asianCheckbox.ScrollAndClickViaJS(_webDriver);
            var asianSelected =_applyPage.asianCheckbox.Selected;
          //   _applyPage.preferNotToSayCheckbox.ScrollAndClickViaJS(_webDriver);
            var preferNotToSaySelected = _applyPage.preferNotToSayCheckbox.Selected;
            
            //_applyPage.submitButton.ScrollAndClickViaJS(_webDriver);

            Assert.IsTrue(asianSelected);
            Assert.IsFalse(preferNotToSaySelected);
        }
        [TestCleanup]
        public void Cleanup() 
        {
            _webDriver.Quit();
            _webDriver.Dispose();
        }
    }
}
