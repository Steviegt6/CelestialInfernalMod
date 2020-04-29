using Terraria.ID;
using Terraria.ModLoader;

namespace CelestialInfernalMod.Projectiles
{
	public class AdamantiteLaser: ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.CloneDefaults(84);
            aiType = 84;
            projectile.friendly = true;
            projectile.hostile = false;
            projectile.tileCollide = false;
            projectile.timeLeft = 300;
            projectile.magic = true;
        }
    }
}