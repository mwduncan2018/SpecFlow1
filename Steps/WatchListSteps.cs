using SpecFlowBdd.PageModels;
using SpecFlowBdd.TestData.WatchListEntry;
using TechTalk.SpecFlow;

namespace SpecFlowBdd.Steps
{
    [Binding]
    public sealed class WatchListSteps
    {
        private readonly ScenarioContext _scenarioContext;

        public WatchListSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [When]
        public void When_entries_are_viewed()
        {
            ((Pages)_scenarioContext["pages"]).NavbarPage.GoToWatchList();
        }

        [Then]
        public void Then_an_entry_can_be_created()
        {
            var pages = (Pages)_scenarioContext["pages"];
            var entry = new WatchListEntryProvider().GetWatchListEntry("1");

            pages.NavbarPage.GoToWatchList();
            pages.WatchListPage.AddNewEntry();
            pages.WatchListAddPage.AddEntry(entry);

            _scenarioContext.Add("entry", entry);
        }

        [Then]
        public void Then_an_entry_can_be_edited()
        {
            var pages = (Pages)_scenarioContext["pages"];
            var entry = (WatchListEntry)_scenarioContext["entry"];

            pages.NavbarPage.GoToWatchList();
            pages.WatchListPage.Edit(entry);
            entry.Manufacturer += " Testing";
            entry.Model += " Testing";
            pages.WatchListEditPage.Edit(entry);
            pages.WatchListPage.VerifyEntryIsDisplayed(entry);
        }

        [Then]
        public void Then_an_entry_can_be_read()
        {
            var pages = (Pages)_scenarioContext["pages"];
            var entry = (WatchListEntry)_scenarioContext["entry"];

            pages.NavbarPage.GoToWatchList();
            pages.WatchListPage.Details(entry);
            pages.WatchListDetailsPage.VerifyDetailsAreDisplayedFor(entry);
        }

        [Then]
        public void Then_an_entry_can_be_deleted()
        {
            var pages = (Pages)_scenarioContext["pages"];
            var entry = (WatchListEntry)_scenarioContext["entry"];

            pages.NavbarPage.GoToWatchList();
            pages.WatchListPage.Delete(entry);
            pages.WatchListDeletePage.ConfirmDelete();
            pages.WatchListPage.VerifyEntryIsNotDisplayed(entry);
        }
    }
}
