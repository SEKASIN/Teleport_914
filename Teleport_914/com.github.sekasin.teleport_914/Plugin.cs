using System;
using Exiled.API.Features;

namespace Teleport_914.com.github.sekasin.teleport_914
{
    public class Teleport_914: Plugin<Config>
    {
        public override string Name => "Teleport_914";
        public override string Author => "Ugi0";
        public override Version Version => new Version(1, 1, 0);
        public EventHandler eventHandler;
        
        public override void OnEnabled() {
            Log.Info("Teleport_914 loading...");
            if (!Config.IsEnabled) {
                Log.Warn("Teleport_914 disabled from config, unloading...");
                OnDisabled();
                return;
            }

            eventHandler = new EventHandler(this);
            Log.Info("Teleport_914 loaded.");
        }

        public override void OnDisabled()
        {
            eventHandler.UnregisterEvents();
            Log.Info("Teleport_914 unloaded.");
        }
    }
}