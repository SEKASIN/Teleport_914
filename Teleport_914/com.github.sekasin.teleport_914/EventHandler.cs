using System.Collections.Generic;
using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.Events.EventArgs.Scp914;
using Handlers = Exiled.Events.Handlers;
using Scp914;
using MEC;
using UnityEngine;
using Random = System.Random;

namespace Teleport_914.com.github.sekasin.teleport_914;

public class EventHandler
{
    private readonly Plugin<Config> _main;
    private readonly bool _debugMode;

    private readonly double HealthLossPercentage;
    private readonly int TeleportChance;
    private List<RoomType> TeleportRooms;
    
    private Random random = new Random();
    
    public EventHandler(Plugin<Config> plugin)
    {
        _main = plugin;
        _debugMode = plugin.Config.Debug;

        HealthLossPercentage = plugin.Config.HealthLossPercentage;
        TeleportChance = plugin.Config.TeleportChance;

        TeleportRooms = plugin.Config.TeleportRooms;
        

        Handlers.Scp914.UpgradingPlayer += UpgradePlayer;
    }

    private void UpgradePlayer(UpgradingPlayerEventArgs ev) {
        if (ev.KnobSetting == Scp914KnobSetting.Rough) {
            ev.Player.Hurt((float) (ev.Player.MaxHealth * HealthLossPercentage));
            if (IsInChance(TeleportChance)) {
                if (_debugMode) {
                    Log.Info("Teleporting " + ev.Player.Nickname + " out of SCP-914.");
                }
                
                Room teleportRoom = Room.Get(TeleportRooms.RandomItem());
                
                if (_debugMode) {
                    Log.Info("Teleporting to " + teleportRoom.Identifier);
                }
                Timing.CallDelayed(0.1f, () =>
                {
                    ev.Player.Teleport(teleportRoom.Position + Vector3.up);
                });
            }
        }
    }
    
    private bool IsInChance(double chance) {
        if (random.Next(100) < chance)
        {
            return true;
        }
        return false;
    }

    public void UnregisterEvents() {
        Handlers.Scp914.UpgradingPlayer -= UpgradePlayer;
    }
}