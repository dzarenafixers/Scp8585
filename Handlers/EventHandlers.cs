using Exiled.Events.EventArgs;
using Exiled.Events.EventArgs.Player;
using PlayerRoles;
using SCP8585 ;

namespace SCP8585Plugin
{
    public class EventHandlers
    {
        public void OnSpawning(SpawningEventArgs ev)
        {
            RoleManager.SetupSCP8585  (ev.Player);
        }

        public void OnVerified(VerifiedEventArgs ev)
        {
            if (ev.Player.Role.Type == RoleTypeId.Tutorial)
            {
                ev.Player.IsIntercomMuted = false; // السماح بالتحدث عبر الانتركم
            }
        }
    }
}