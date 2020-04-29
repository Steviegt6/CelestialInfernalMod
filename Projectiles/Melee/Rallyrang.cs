using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CelestialInfernalMod.Projectiles.Melee
{
	public class Rallyrang : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Checkers");
		}

		public override void SetDefaults()
		{
            projectile.CloneDefaults(ProjectileID.EnchantedBoomerang);
            projectile.tileCollide = true;
            aiType = ProjectileID.EnchantedBoomerang;
            projectile.timeLeft = 300;
			projectile.friendly = true;
		}
	}
}
