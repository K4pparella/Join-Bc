namespace ExamplePlugin
{
    using CensusAPI.Enums;
    using CensusAPI.Features;
    using CensusCore.Events.Attributes;
    using CensusCore.Events.EventArgs.Player;
    using PluginFramework.Attributes;
    using PluginFramework.Classes;
    using PluginFramework.Events.EventsArgs;
    using System;
    using VirtualBrightPlayz.SCP_ET.Items.ItemSystem;

    public class JoinBroadcast : IScript
    {
        [PlayerEvent(PlayerEventType.OnPlayerJoinFinal)]
        public static void OnPlayerJoin(PlayerJoinFinalEvent ev)
        {
            Player player = Player.Get(ev.player);
            player.SendChatMessage($"Hello, welcome to our server {player.Nickname}!");
            player.AddMission("Enjoy the game!");
        }
    }
}
