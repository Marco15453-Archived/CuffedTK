using System;
using System.Collections.Generic;
using Exiled.API.Enums;
using Exiled.API.Features;
using CuffedTK.Events;

namespace CuffedTK {
    public class CuffedTK : Plugin<Config> {
        internal static CuffedTK Instance { get; private set; }

        private PlayerHandler playerHandler;

        public override void OnEnabled() {
            Instance = this;
            registerEvents();
            base.OnEnabled();
        }

        public override void OnDisabled() {
            unregisterEvents();
            base.OnDisabled();
        }

        private void registerEvents() {
            playerHandler = new PlayerHandler();

            // Player
            Exiled.Events.Handlers.Player.Hurting += playerHandler.onHurting;
        }

        private void unregisterEvents() {
            // Player
            Exiled.Events.Handlers.Player.Hurting -= playerHandler.onHurting;

            playerHandler = null;
        }
    }
}
