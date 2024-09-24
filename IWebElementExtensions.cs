using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace UnitTestProjectIC
{
    public static class IWebElementExtensions
    {
        public static void SelectTextFromDropdown(this IWebElement element, string dropdownText)
        {
            SelectElement select = new SelectElement(element);
            select.SelectByText(dropdownText);
        }
        public static void SelectValueFromDropdown(this IWebElement element, string dropdownText)
        {
            SelectElement select = new SelectElement(element);
            select.SelectByValue(dropdownText);
        }
        public static void SelectIndexFromDropdown(this IWebElement element, int dropdownText)
        {
            SelectElement select = new SelectElement(element);
            select.SelectByIndex(dropdownText);
        }
        public static void ClickButton(this IWebElement element,IWebDriver driver)
        {
            Actions a = new Actions(driver);
            a.ScrollToElement(element).Click(element).Perform();
        }
        public static void ScrollAndClickViaJS(this IWebElement element, IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView(true);", element);
            js.ExecuteScript("arguments[0].click();", element);
        }
    }
}
