using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFlowBdd.Extensions
{
    public static class SeleniumExtensions
    {
        /// <summary>
        /// Use when you want to wait for an element. 
        /// The first TimeSpan is the max time you want to wait for the element to appear. 
        /// The second TimeSpan is how often to check for the element.
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="by"></param>
        /// <param name="timeout"></param>
        /// <param name="pollingInterval"></param>
        /// <returns>If found, the element is returned.</returns>
        public static IWebElement FindElement(this IWebDriver driver, By by, TimeSpan timeout, TimeSpan pollingInterval)
        {
            var wait = new DefaultWait<IWebDriver>(driver);
            wait.Timeout = timeout;
            wait.PollingInterval = pollingInterval;
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            return wait.Until(x => { return x.FindElement(by); });
        }
    }
}
