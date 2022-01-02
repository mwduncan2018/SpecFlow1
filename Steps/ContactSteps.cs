using System.Linq;
using TechTalk.SpecFlow;
using SpecFlowBdd.PageModels;

namespace SpecFlowBdd.Steps
{
    [Binding]
    public sealed class ContactSteps
    {
        private readonly ScenarioContext _scenarioContext;

        public ContactSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [When]
        public void When_the_Contact_page_is_viewed()
        {
            ((Pages)_scenarioContext["pages"]).NavbarPage.GoToContact();
        }

        [Then]
        public void Then_a_GitHub_link_should_be_provided(string text)
        {
            ((Pages)_scenarioContext["pages"]).ContactPage.VerifyGitHubLinkDestinationIs(text);
        }

        [Then]
        public void Then_the_following_skills_should_be_listed(Table table)
        {
            foreach (var skill in table.Rows.Select(x => x.Values.First()))
                ((Pages)_scenarioContext["pages"]).ContactPage.VerifySkillIsDisplayed(skill);
        }

        [Then]
        public void Then_the_following_text_should_display_in_the_footer(string text)
        {
            ((Pages)_scenarioContext["pages"]).ContactPage.VerifyFooterContainsText(text);
        }
    }
}