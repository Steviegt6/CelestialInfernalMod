using Terraria.ID;
using Terraria.ModLoader;

namespace CelestialInfernalMod.Projectiles.Magic
{
	public class Friendlaser: ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.NebulaLaser);
            aiType = ProjectileID.NebulaLaser;
            projectile.friendly = true;
            projectile.hostile = false;
            projectile.tileCollide = true;
            projectile.timeLeft = 300;
			projectile.magic = true;
        }
    }
}