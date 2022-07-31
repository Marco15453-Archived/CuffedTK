﻿using Exiled.API.Features;
using System;

namespace CuffedTK
{
    public class CuffedTK : Plugin<Config>
    {
        public override string Name => "CuffedTK";
        public override string Author => "Marco15453";
        public override string Prefix => "CTK";
        public override Version Version => new Version(1, 12, 0);
        public override Version RequiredExiledVersion => new Version(5, 3, 0);

        private EventHandler eventHandler;

        public override void OnEnabled()
        {
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
            eventHandler = new EventHandler(this);

            // Player
            Exiled.Events.Handlers.Player.Hurting += eventHandler.onHurting;
        }

        private void unregisterEvents()
        {
            // Player
            Exiled.Events.Handlers.Player.Hurting -= eventHandler.onHurting;

            eventHandler = null;
        }
    }
}
