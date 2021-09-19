using System;
using Exiled.API.Enums;
using Exiled.API.Features;
using CuffedTK.Events;

namespace CuffedTK 
{
    public class CuffedTK : Plugin<Config> 
    {
        internal static CuffedTK Instance;

        public override string Name => "CuffedTK";
        public override string Author => "Marco15453";
        public override string Prefix => "CTK";
        public override Version Version => new Version(1, 5, 0);
        public override Version RequiredExiledVersion => new Version(3, 0, 0);

        private PlayerHandler playerHandler;

        public override void OnEnabled() 
        {
            Instance = this;
            registerEvents();
            base.OnEnabled();
        }

        public override void OnDisabled() 
        {
            unregisterEvents();
            base.OnDisabled();
        }

        private void registerEvents() 
        {
            playerHandler = new PlayerHandler();

            // Player
            Exiled.Events.Handlers.Player.Hurting += playerHandler.onHurting;
        }

        private void unregisterEvents() 
        {
            // Player
            Exiled.Events.Handlers.Player.Hurting -= playerHandler.onHurting;

            playerHandler = null;
        }
    }
}
