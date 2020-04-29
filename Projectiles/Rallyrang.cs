using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CelestialInfernalMod.Projectiles
{
	public class Rallyrang : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Checkers");
		}

		public override void SetDefaults()
		{
            projectile.CloneDefaults(6);
            projectile.tileCollide = true;
            aiType = 6;
            projectile.timeLeft = 300;
			projectile.friendly = true;
		}
	}
}
