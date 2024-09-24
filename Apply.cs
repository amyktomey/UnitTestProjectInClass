using OpenQA.Selenium;

namespace UnitTestProjectIC
{
    public class ApplyPage
    {
        public IWebDriver _driver;
        public ApplyPage(IWebDriver driver)
        {
            _driver = driver;
        }
        public string applyPageUrl = "https://code-you.org/apply/";

        public IWebElement emailTextBox => _driver.FindElement(By.Id("tfa_215"));
        public IWebElement firstNameTextBox =>  _driver.FindElement(By.Id("tfa_2")); 
        public IWebElement lastNameTextBox =>  _driver.FindElement(By.Id("tfa_3")); 
        public IWebElement preferrredNameTextBox => _driver.FindElement(By.Id("tfa_1230"));
        public IWebElement phoneNumberTextBox => _driver.FindElement(By.Id("tfa_216"));
        public IWebElement birthdayTextBox => _driver.FindElement(By.Id("tfa_5"));
        public IWebElement streetAddressTextBox => _driver.FindElement(By.Id("tfa_6"));
        public IWebElement cityTextBox => _driver.FindElement(By.Id("tfa_7"));
        public IWebElement stateDropdown => _driver.FindElement(By.Id("tfa_238"));
        public IWebElement zipCodeTextBox => _driver.FindElement(By.Id("tfa_9"));
        public IWebElement countyDropdown => _driver.FindElement(By.Id("tfa_1242")); 
        public IWebElement genderDropdown => _driver.FindElement(By.Id("tfa_30"));
        public IWebElement americanIndianOrAlaskanNativeCheckbox => _driver.FindElement(By.Id("tfa_795-L"));
        public IWebElement asianCheckbox => _driver.FindElement(By.Id("tfa_796-L"));
        public IWebElement blackOrAfricanAmericanCheckbox => _driver.FindElement(By.Id("tfa_824-L"));
        public IWebElement hispanicLatinoCheckbox => _driver.FindElement(By.Id("tfa_1254-L"));
        public IWebElement middleEasternOrNorthAfricanCheckbox => _driver.FindElement(By.Id("tfa_1253-L"));
        public IWebElement nativeHawaiianOrOtherPacificIslanderCheckbox => _driver.FindElement(By.Id("tfa_797-L"));
        public IWebElement whiteCheckbox => _driver.FindElement(By.Id("tfa_798-L"));
        public IWebElement otherCheckbox => _driver.FindElement(By.Id("tfa_799-L"));
        public IWebElement preferNotToSayCheckbox => _driver.FindElement(By.Id("tfa_800-L"));


        public IWebElement submitButton => _driver.FindElement(By.Id("submit_Button"));

    }
}
