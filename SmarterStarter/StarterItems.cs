using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using TShockAPI;

namespace SmarterStarter
{
    public class StarterItems
    {
        public class Item
        {
            public int netID { get; set; }
            public int prefix { get; set; }
            public int stack { get; set; }
        }

        public class PlayerSettings
        {
            public int health { get; set; }
            public int mana { get; set; }
            public StarterItems.Item[] items { get; set; }
        }

        public static void Set(PlayerSettings settings) {
            string path = File.ReadAllText("tshock/sscconfig.json");
            dynamic jsonObject = JsonConvert.DeserializeObject(path);
            jsonObject["StartingHealth"] = settings.health;
            jsonObject["StartingMana"] = settings.mana;
            jsonObject["StartingInventory"] = JToken.FromObject(settings.items);
            dynamic jsonObjectNew = JsonConvert.SerializeObject(jsonObject, Formatting.Indented);
            File.WriteAllText("tshock/sscconfig.json", jsonObjectNew);

            TShock.Utils.Reload();

            Console.WriteLine("SSC items have been updated.");
        }
    }
}
