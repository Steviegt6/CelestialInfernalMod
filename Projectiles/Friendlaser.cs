using Terraria.ID;
using Terraria.ModLoader;

namespace CelestialInfernalMod.Projectiles
{
	public class Friendlaser: ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.CloneDefaults(576);
            aiType = 576;
            projectile.friendly = true;
            projectile.hostile = false;
            projectile.tileCollide = true;
            projectile.timeLeft = 300;
        }
    }
}