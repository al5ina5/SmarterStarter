using System;
using System.IO;
using Newtonsoft.Json;

namespace SmarterStarter
{
    public class PluginSettings
    {
        public PluginSettings()
        {
        }

        public static Bosses GetBosses;

        public class Bosses
        {
            public StarterItems.PlayerSettings EoC { get; set; }
            public StarterItems.PlayerSettings KingSlime { get; set; }
            public StarterItems.PlayerSettings BoC { get; set; }
            public StarterItems.PlayerSettings QueenBee { get; set; }
            public StarterItems.PlayerSettings Skeletron { get; set; }
            public StarterItems.PlayerSettings WoF { get; set; }
            public StarterItems.PlayerSettings Destoryer { get; set; }
            public StarterItems.PlayerSettings Twins { get; set; }
            public StarterItems.PlayerSettings SkeletronPrime { get; set; }
            public StarterItems.PlayerSettings Plantera { get; set; }
            public StarterItems.PlayerSettings Golem { get; set; }
            public StarterItems.PlayerSettings Fishron { get; set; }
            public StarterItems.PlayerSettings MoonLord { get; set; }
        }

        public static void LoadSettings()
        {
            var path = "tshock/smarterstarter.json";
            if (!File.Exists(path)) {
                Console.WriteLine("SmarterStarter configuration not found.");
            } else
            {
                Bosses loadedBosses = JsonConvert.DeserializeObject<Bosses>(File.ReadAllText(path));

                GetBosses = loadedBosses;

                Console.WriteLine("SmarterStarter configuration loaded.");
            }
        }
    }
}
