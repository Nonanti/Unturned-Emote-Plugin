using System;
using Rocket.Core.Logging;
using Rocket.Core.Plugins;

namespace EmotePlugins
{
    public class EmotePlugin : RocketPlugin
    {
        protected override void Load()
        {
            Logger.Log("Eklenti çalısıyor.");
        }
    }
}
