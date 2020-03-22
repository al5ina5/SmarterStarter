using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmarterStarter
{
    class StarterItems
    {
        public class Item
        {
            public int netID { get; set; }
            public int prefix { get; set; }
            public int stack { get; set; }
        }

        public static void Set(int health, int mana, Array items) {

            //StarterItems.Item[] items = new StarterItems.Item[3];

            //items[0] = new StarterItems.Item()
            //{
            //    netID = 30,
            //    prefix = 0,
            //    stack = 1
            //};

            //items[1] = new StarterItems.Item()
            //{
            //    netID = 40,
            //    prefix = 0,
            //    stack = 1
            //};

            //items[2] = new StarterItems.Item()
            //{
            //    netID = 60,
            //    prefix = 0,
            //    stack = 3
            //};

            string path = File.ReadAllText("tshock/sscconfig.json");
            dynamic jsonObject = JsonConvert.DeserializeObject(path);
            jsonObject["StartingHealth"] = health;
            jsonObject["StartingMana"] = mana;
            jsonObject["StartingInventory"] = JToken.FromObject(items);
            dynamic jsonObjectNew = JsonConvert.SerializeObject(jsonObject, Formatting.Indented);
            File.WriteAllText("tshock/sscconfig.json", jsonObjectNew);
        }
    }
}
