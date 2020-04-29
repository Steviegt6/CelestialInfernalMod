using Terraria.ID;
using Terraria.ModLoader;

namespace CelestialInfernalMod.Projectiles
{
	public class MagicalIceBolt: ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.CloneDefaults(118);
            aiType = 118;
            projectile.friendly = true;
            projectile.hostile = false;
            projectile.tileCollide = true;
            projectile.magic = true;
            projectile.melee = false;
            projectile.timeLeft = 300;
        }
    }
}