using Exiled.API.Features;
using PlayerRoles;
using PlayerRoles.PlayableScps.Scp049;
using SCP8585;

namespace SCP8585Plugin
{
    public static class RoleManager
    {
        public static void SetupSCP8585(Player player)
        {
            if (player.Role.Type == RoleTypeId.Tutorial) // تحويل دور التوتوريال إلى SCP 8585
            {
                var config = MainPlugin.Singleton.Config;

                player.Role.Set(RoleTypeId.Tutorial);
                player.Health = config.Scp8585Health; // ضبط صحة SCP 8585
                player.ClearInventory(); // مسح الجرد الحالي
                player.AddItem(ItemType.GunCOM15); // إضافة سلاح مثال
                player.AddItem(ItemType.Medkit); // إضافة أدوات أخرى
                
                // إضافة تأثيرات القدرات الخاصة
                player.Stamina = config.Scp8585SpeedMultiplier; // ضبط سرعة SCP 8585
                
                player.Broadcast(10, $"لقد تم تحويلك إلى {config.Scp8585Code}!");
            }
        }
    }
}