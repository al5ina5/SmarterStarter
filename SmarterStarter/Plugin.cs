using Newtonsoft.Json.Linq;
using System;
using Terraria;
using TerrariaApi.Server;
using TShockAPI;

namespace SmarterStarter
{
    [ApiVersion(2, 1)]
    public class Plugin : TerrariaPlugin
    {
        public override string Name => "SmarterStarter";
        public override Version Version => new Version(1, 0, 0);
        public override string Author => "Sebastian Alsina";
        public override string Description => "SmarterStarter changes SSC's starer items based on boss progression.";

        public Plugin(Main game) : base(game)
        {

        }
        public override void Initialize()
        {
            Console.WriteLine("The plugin has initialized. Yay!");

            StarterItems.Item[] items = new StarterItems.Item[3];
            items[0] = new StarterItems.Item()
            {
                netID = 30,
                prefix = 0,
                stack = 1
            };

            items[1] = new StarterItems.Item()
            {
                netID = 40,
                prefix = 0,
                stack = 1
            };

            items[2] = new StarterItems.Item()
            {
                netID = 60,
                prefix = 0,
                stack = 3
            };

            StarterItems.Set(300, 40, items);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                // dispose
            }
            base.Dispose(disposing);
        }

    }
}
