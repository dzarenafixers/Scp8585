using System;
using Exiled.API.Features;
using SCP8585Plugin;
using Player = Exiled.Events.Handlers.Player;

namespace SCP8585
{
    public class MainPlugin : Plugin<Config>
    {
        public static MainPlugin Singleton;

        public override string Name => "SCP8585Plugin";
        public override string Author => "dzarenafixers&moncef50g";
        public override Version RequiredExiledVersion => new Version(9, 5, 0); // تأكد من استخدام النسخة الصحيحة

        private EventHandlers eventHandlers;

        public override void OnEnabled()
        {
            Singleton = this;
            base.OnEnabled();
            eventHandlers = new EventHandlers();
            Player.Spawning += eventHandlers.OnSpawning;
            Player.Verified += eventHandlers.OnVerified;
        }

        public override void OnDisabled()
        {
            Player.Spawning -= eventHandlers.OnSpawning;
            Player.Verified -= eventHandlers.OnVerified;
            eventHandlers = null;
            Singleton = null;
            base.OnDisabled();
        }
    }
}