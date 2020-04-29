using Terraria.ID;
using Terraria.ModLoader;

namespace CelestialInfernalMod.Projectiles
{
	public class Freed: ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.CloneDefaults(275);
            aiType = 275;
            projectile.friendly = true;
            projectile.hostile = false;
            projectile.tileCollide = true;
            projectile.timeLeft = 300;
            projectile.thrown = true;
        }
    }
}