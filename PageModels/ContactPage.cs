using System;
using System.Linq;
using OpenQA.Selenium;
using FluentAssertions;
using SpecFlowBdd.Extensions;

namespace SpecFlowBdd.PageModels
{
    public class ContactPage
    {
        private IWebDriver _driver;
        public ContactPage(IWebDriver driver)
        {
            _driver = driver;
        }

        #region Locators
        private By _textSecretMessage = By.Id("secretMessage");
        private By _linkGitHub = By.CssSelector("#github a");
        private By _listSkills = By.CssSelector("#skillList li");
        #endregion

        #region Verification Actions
        public void VerifyGitHubLinkDestinationIs(string text)
        {
            _driver.FindElement(_linkGitHub)
                .GetAttribute("href")
                .Should()
                .Be(text);
        }

        public void VerifyFooterContainsText(string text)
        {
            _driver.FindElement(_textSecretMessage, TimeSpan.FromSeconds(10), TimeSpan.FromSeconds(1)).Text
                .Should()
                .Contain(text);
        }

        public void VerifySkillIsDisplayed(string skill)
        {
            _driver.FindElements(_listSkills)
                .Select(x => x.Text)
                .Select(y => y.Replace("::marker", ""))
                .Should().Contain(skill);
        }
        #endregion
    }
}
