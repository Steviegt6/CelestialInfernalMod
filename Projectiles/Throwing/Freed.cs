using Terraria.ID;
using Terraria.ModLoader;

namespace CelestialInfernalMod.Projectiles.Throwing
{
	public class Freed: ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.SeedPlantera);
            aiType = ProjectileID.SeedPlantera;
            projectile.friendly = true;
            projectile.hostile = false;
            projectile.tileCollide = true;
            projectile.timeLeft = 300;
            projectile.thrown = true;
        }
    }
}