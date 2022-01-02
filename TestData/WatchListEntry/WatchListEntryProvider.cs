using System;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Collections.Generic;

namespace SpecFlowBdd.TestData.WatchListEntry
{
    public class WatchListEntryProvider
    {
        public WatchListEntryProvider() { }

        public List<WatchListEntry> GetAllEntries()
        {
            return JsonSerializer.Deserialize<List<WatchListEntry>>(File.ReadAllText(GetWatchListTestDataDirectory()));
        }

        public WatchListEntry GetWatchListEntry(string id)
        {
            return GetAllEntries()
                .Where(x => x.Id == id)
                .FirstOrDefault();
        }

        public WatchListEntry GetWatchListEntry(string manufacturer, string model)
        {
            return GetAllEntries()
                .Where(x => x.Manufacturer == manufacturer)
                .Where(y => y.Model == model)
                .FirstOrDefault();
        }

        public string PrintJsonForEntry(WatchListEntry entry)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize<WatchListEntry>(entry, options);
            Console.WriteLine(json);
            return json;
        }

        public string PrintJsonForWatchList(IEnumerable<WatchListEntry> collection)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize<IEnumerable<WatchListEntry>>(collection, options);
            Console.WriteLine(json);
            return json;
        }

        private string GetWatchListTestDataDirectory()
        {
            var w = AppDomain.CurrentDomain.BaseDirectory;
            w = (Directory.GetParent(w)).FullName;
            w = (Directory.GetParent(w)).FullName;
            w = (Directory.GetParent(w)).FullName;
            w = (Directory.GetParent(w)).FullName;
            w = (Directory.GetParent(w)).FullName;
            w = (Directory.GetParent(w)).FullName;
            w = w + "\\TestData\\WatchListEntry\\watch-list-test-data.json";
            return w;
        }
    }
}
