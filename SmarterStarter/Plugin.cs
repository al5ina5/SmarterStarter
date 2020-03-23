using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
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
            PluginSettings.LoadSettings();
            ServerApi.Hooks.ServerJoin.Register(this, OnServerJoin);
        }

        void OnServerJoin(JoinEventArgs args)
        {
            CheckBosses.Check();
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
