using Terraria.ID;
using Terraria.ModLoader;

namespace CelestialInfernalMod.Projectiles.Magic
{
	public class MagicalIceBolt: ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.IceBolt);
            aiType = ProjectileID.IceBolt;
            projectile.friendly = true;
            projectile.hostile = false;
            projectile.tileCollide = true;
            projectile.magic = true;
            projectile.melee = false;
            projectile.timeLeft = 300;
        }
    }
}