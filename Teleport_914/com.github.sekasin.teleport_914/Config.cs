using System.Collections.Generic;
using System.ComponentModel;
using Exiled.API.Enums;
using Exiled.API.Interfaces;

namespace Teleport_914.com.github.sekasin.teleport_914
{
    public class Config : IConfig {
        [Description("Is the Plugin enabled.")]
        public bool IsEnabled { get; set; } = true;

        [Description("Debug mode.")]
        public bool Debug { get; set; } = false;

        [Description("How many percentages should a player lose when trying to teleport. Give a value between 0 and 1.")]
        public double HealthLossPercentage { get; set; } = 0.3;

        [Description("What is the chance that a person will teleport out. Give a value between 0 and 100")]
        public int TeleportChance { get; set; } = 50;
        
        [Description("Determines what rooms can be teleported to using SCP-914 teleportation.")]
        public List<RoomType> TeleportRooms { get; set; } = new List<RoomType> { RoomType.LczCafe, RoomType.LczCrossing, RoomType.LczStraight, RoomType.LczTCross, RoomType.LczPlants, RoomType.LczClassDSpawn, RoomType.LczGlassBox, RoomType.LczToilets, RoomType.LczAirlock };
    }
}