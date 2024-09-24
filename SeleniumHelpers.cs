using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace UnitTestProjectIC
{
    public class SeleniumHelpers
    { 
        public IWebDriver _driver;
        public SeleniumHelpers(IWebDriver d)
        {
            _driver = d;
        }


        public void SelectTextFromDropdown(IWebElement element, string dropdownText) 
            {
            SelectElement select = new SelectElement(element);
            select.SelectByText(dropdownText);
            }
        public void SelectValueFromDropdown(IWebElement element, string dropdownText)
        {
            SelectElement select = new SelectElement(element);
            select.SelectByValue(dropdownText);
        }
        public void SelectIndexFromDropdown(IWebElement element, int dropdownText)
        {
            SelectElement select = new SelectElement(element);
            select.SelectByIndex(dropdownText);
        }
        public void ClickButton(IWebElement element)
        {
            Actions a = new Actions(_driver);
            a.ScrollToElement(element).Click(element).Perform();
        }
        public void ScrollAndClickViaJS(IWebElement element)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)_driver;
            js.ExecuteScript("arguments[0].scrollIntoView(true);", element);
            js.ExecuteScript("arguments[0].click();", element);
        }
    }
}